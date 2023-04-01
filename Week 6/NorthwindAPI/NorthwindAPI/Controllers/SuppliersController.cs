using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Data;
using NorthwindAPI.Data.Repositories;
using NorthwindAPI.Models;
using NorthwindAPI.Models.DTO;
using NorthwindAPI.Services;
using NuGet.Protocol.Core.Types;

namespace NorthwindAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuppliersController : ControllerBase
{
    private readonly INorthwindService<Supplier> _supplierService;

    public SuppliersController(INorthwindService<Supplier> supplierService)
    {
        _supplierService = supplierService;
    }

    // GET: api/Suppliers
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SupplierDTO>>> GetSuppliers()
    {
        return (await _supplierService.GetAllAsync())
            .Select(s => Utils.SupplierToDTO(s))
            .ToList();
    }

    // GET: api/Suppliers/5
    [HttpGet("{id}")]
    public async Task<ActionResult<SupplierDTO>> GetSupplier(int id)
    {
        var supplier = await _supplierService.GetAsync(id);

        if (supplier == null)
        {
            return NotFound();
        }

        return Utils.SupplierToDTO(supplier);
    }

    // GET: api/suppliers/5/products
    [HttpGet("{id}/products")]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProductsBySupplier(int id)
    {
        var supplier = await _supplierService.GetAsync(id);

        if (supplier == null)
        {
            return NotFound();
        }

        return supplier
            .Products.Select(p => Utils.ProductToDTO(p))
            .ToList();
    }

    // PUT: api/Suppliers/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    public async Task<IActionResult> PutSupplier(int id,
            [Bind("SupplierId", "CompanyName", "ContactName", "ContactTitle", "Country", "Products")] Supplier supplier)
    {
        if (id != supplier.SupplierId)
        {
            return BadRequest();
        }

        var updatedSuccessfully = await _supplierService.UpdateAsync(id, supplier);

        if (!updatedSuccessfully)
        {
            return NotFound();
        }
        return NoContent();
    }

    // POST: api/Suppliers
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<SupplierDTO>> PostSupplier(
        [Bind("CompanyName", "ContactName", "ContactTitle", "Country", "Products")] Supplier supplier)
    {
        bool created = await _supplierService.CreateAsync(supplier);

        if (created == false)
        {
            return Problem("Entity set 'NorthwindContext.Suppliers'  is null.");
        }

        return CreatedAtAction("GetSupplier", new { id = supplier.SupplierId }, Utils.SupplierToDTO(supplier));
    }

    // DELETE: api/Suppliers/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSupplier(int id)
    {
        var deleted = await _supplierService.DeleteAsync(id);

        if (deleted == false)
        {
            return NotFound();
        }

        return NoContent();
    }

    private async Task<bool> SupplierExists(int id)
    {
        return await _supplierService.EntityExists(id);
    }
}
