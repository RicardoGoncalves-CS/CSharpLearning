using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Data.Repositories;
using NorthwindAPI.Data;
using NorthwindAPI.Models.DTO;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    //private readonly NorthwindContext _context;
    private readonly ILogger _logger;
    private readonly INorthwindRepository<Product> _productRepository;

    public ProductsController(
        NorthwindContext context,
        ILogger<ProductsController> logger,
        INorthwindRepository<Product> productRepository)
    {
        //_context = context;
        _logger = logger;
        _productRepository = productRepository;
    }

    // GET: api/products
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
    {
        if (_productRepository.IsNull)
        {
            return NotFound();
        }
        return (await _productRepository.GetAllAsync())
            .Select(p => Utils.ProductToDTO(p))
            .ToList();
    }

    // GET: api/products/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDTO>> GetProduct(int id)
    {
        if (_productRepository.IsNull)
        {
            return NotFound();
        }

        var product = await _productRepository.FindAsync(id);
        //.Where(s => s.SupplierId == id)
        //.Include(s => s.Products)
        //.FirstOrDefaultAsync();

        if (product == null)
        {
            _logger.LogWarning($"Supplier with id:{id} was not found");
            return NotFound();
        }

        _logger.LogInformation($"Supplier with id:{id} was found");
        return Utils.ProductToDTO(product);
    }

    // GET: api/products/5/supplier
    [HttpGet("{id}/supplier")]
    public async Task<ActionResult<SupplierDTO>> GetSupplierByProduct(int id)
    {
        if (_productRepository.IsNull)
        {
            return NotFound();
        }

        var product = await _productRepository.FindAsync(id);
        
        //.Where(s => s.SupplierId == id)
        //.Include(s => s.Products)
        //.FirstOrDefaultAsync();

        if (product == null)
        {
            return NotFound();
        }

        var supplier = product.Supplier != null ? Utils.SupplierToDTO(product.Supplier) : null;

        return supplier;
    }

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

        _productRepository.Update(product);

        try
        {
            await _productRepository.SaveAsync(); //_context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ProductExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Suppliers
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<ProductDTO>> PostSupplier(
        [Bind("ProductName", "SupplierId", "CategoryId", "UnitPrice")] Product product)
    {
        if (_productRepository.IsNull)
        {
            return Problem("Entity set 'NorthwindContext.Suppliers'  is null.");
        }

        _productRepository.Add(product);
        await _productRepository.SaveAsync();

        return CreatedAtAction("GetSupplier", new { id = product.ProductId }, Utils.ProductToDTO(product));
    }

    // DELETE: api/Suppliers/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        if (_productRepository.IsNull)
        {
            return NotFound();
        }

        var product = await _productRepository.FindAsync(id);
        //.Where(s => s.SupplierId == id)
        //.Include(s => s.Products)
        //.FirstOrDefaultAsync();

        if (product == null)
        {
            return NotFound();
        }

        //supplier.Products.Select(p => p.SupplierId = null);

        _productRepository.Remove(product);
        await _productRepository.SaveAsync();

        return NoContent();
    }

    private bool ProductExists(int id)
    {
        return _productRepository.FindAsync(id) != null;
    }
}

