using WebAppDemo.REST.DAL.Entities;

namespace WebAppDemo.REST.BLL.Interfaces;

public interface IProductsService
{
    Task<Product> AddProdcut(Product product);
    Task<IEnumerable<Product>> GetProducts(int skip, int take);
}
