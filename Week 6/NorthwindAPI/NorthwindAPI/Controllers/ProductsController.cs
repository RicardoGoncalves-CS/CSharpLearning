using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Data.Repositories;
using NorthwindAPI.Data;
using NorthwindAPI.Models.DTO;
using NorthwindAPI.Models;
using NorthwindAPI.Services;

namespace NorthwindAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly INorthwindService<Product> _productService;

    public ProductsController(INorthwindService<Product> productService)
    {
        _productService = productService;
    }

    // GET: api/products
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
    {
        return (await _productService.GetAllAsync())
            .Select(s => Utils.ProductToDTO(s))
            .ToList();
    }

    // GET: api/products/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDTO>> GetProduct(int id)
    {
        var products = await _productService.GetAsync(id);

        if (products == null)
        {
            return NotFound();
        }

        return Utils.ProductToDTO(products);
    }

    // GET: api/products/5/supplier
    //[HttpGet("{id}/supplier")]
    //public async Task<ActionResult<SupplierDTO>> GetSupplierByProduct(int id)
    //{
    //    if (_productRepository.IsNull)
    //    {
    //        return NotFound();
    //    }

    //    var product = await _productRepository.FindAsync(id);
        
    //    //.Where(s => s.SupplierId == id)
    //    //.Include(s => s.Products)
    //    //.FirstOrDefaultAsync();

    //    if (product == null)
    //    {
    //        return NotFound();
    //    }

    //    var supplier = product.Supplier != null ? Utils.SupplierToDTO(product.Supplier) : null;

    //    return supplier;
    //}

    // PUT: api/Suppliers/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutProduct(int id,
        [Bind("ProductName", "SupplierId", "CategoryId", "UnitPrice")] Product product)
    {
        if (id != product.ProductId)
        {
            return BadRequest();
        }

        var updatedSuccessfully = await _productService.UpdateAsync(id, product);

        if (!updatedSuccessfully)
        {
            return NotFound();
        }
        return NoContent();
    }

    // POST: api/Suppliers
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<ProductDTO>> PostProduct(
        [Bind("ProductName", "SupplierId", "CategoryId", "UnitPrice")] Product product)
    {
        bool created = await _productService.CreateAsync(product);

        if (created == false)
        {
            return Problem("Entity set 'NorthwindContext.Products'  is null.");
        }

        return CreatedAtAction("GetProduct", new { id = product.ProductId }, Utils.ProductToDTO(product));
    }

    // DELETE: api/Suppliers/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var deleted = await _productService.DeleteAsync(id);

        if (deleted == false)
        {
            return NotFound();
        }

        return NoContent();
    }

    private async Task<bool> ProductExists(int id)
    {
        return await _productService.EntityExists(id);
    }
}

