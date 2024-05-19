using Microsoft.EntityFrameworkCore;
using SamplePickles.Data;
using SamplePickles.Models;


namespace SamplePickles.Services;

public class ProductService
{
    private readonly PickleDbContext productContext;

    public ProductService(PickleDbContext context)
    {
        productContext = context;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await productContext
            .Products
            .Include(p => p.ProductType)
            .AsNoTracking()
            .ToListAsync();          
    }

    public async Task<Product> GetProductById(int productId)
    {
        return await productContext.Products.Where(p => p.Id == productId).AsNoTracking().FirstOrDefaultAsync();
    }
}
