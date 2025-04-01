using WebAppDemo.REST.DAL.Entities;

namespace WebAppDemo.REST.BLL.Interfaces;

public interface ICategoryService
{
    Task<Category> AddCategory(Category category);
    Task<IEnumerable<Category>> GetCategories(int skip, int take);
}
