using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Models;

namespace NorthwindAPI.Data.Repositories;

public class SupplierRepository : NorthwindRepository<Customer>
{
    public SupplierRepository(NorthwindContext context) : base(context)
    {
    }

    public override async Task<Customer?> FindAsync(int id) 
    { 
        return await _dbSet
            .Where(s => s.SupplierId == id)
            .Include(s => s.Products)
            .FirstOrDefaultAsync(); 
    }

    public override async Task<IEnumerable<Customer>> GetAllAsync() 
    { 
        return await _dbSet.Include(s => s.Products).ToListAsync(); 
    }
}
