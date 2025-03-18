using Microsoft.EntityFrameworkCore;
using WebAppDemo.REST.BLL.Interfaces;
using WebAppDemo.REST.DAL;
using WebAppDemo.REST.DAL.Entities;

namespace WebAppDemo.REST.BLL.Services;

public class ProductsService : IProductsService
{
    private WebAppDemoContext _context;

    public ProductsService(WebAppDemoContext context)
    {
        _context = context;
    }

    public async Task<Product> AddProdcut(
        Product product) 
    {
        var result = await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<IEnumerable<Product>> GetProducts(int skip, int take) 
    {
        var result = await _context.Products
            .Skip(skip).Take(take).ToListAsync();
        return result;
    }
}
