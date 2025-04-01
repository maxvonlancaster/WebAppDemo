using Microsoft.EntityFrameworkCore;
using WebAppDemo.REST.BLL.Interfaces;
using WebAppDemo.REST.DAL;
using WebAppDemo.REST.DAL.Entities;

namespace WebAppDemo.REST.BLL.Services;

public class CategoryService : ICategoryService
{
    private WebAppDemoContext _context;

    public CategoryService(WebAppDemoContext context)
    {
        _context = context;
    }

    public async Task<Category> AddCategory(
        Category category)
    {
        var result = await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<IEnumerable<Category>> GetCategories(int skip, int take)
    {
        var result = await _context.Categories
            .Skip(skip).Take(take).ToListAsync();
        return result;
    }
}
