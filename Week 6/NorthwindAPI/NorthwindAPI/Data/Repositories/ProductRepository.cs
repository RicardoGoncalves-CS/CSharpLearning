using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Models;

namespace NorthwindAPI.Data.Repositories;

public class ProductRepository : NorthwindRepository<Product>
{
    public ProductRepository(NorthwindContext context) : base(context)
    {
    }

    public override async Task<Product?> FindAsync(int id)
    {
        return await _dbSet
            .Where(p => p.ProductId == id)
            .FirstOrDefaultAsync();
    }

    public override async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
}