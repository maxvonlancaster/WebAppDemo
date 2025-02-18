using WebAppDemo.Models;

namespace WebAppDemo.Services;

// dependency inversion
public interface IProductsService
{
    Product GetProductById(int id);
    List<Product> GetProducts();
    void AddProdcut(Product product);
}
