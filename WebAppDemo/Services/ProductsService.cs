using WebAppDemo.Models;

namespace WebAppDemo.Services;

public class ProductsService : IProductsService
{
    private List<Product> _products;

    public ProductsService()
    {
        _products = new List<Product>() 
        { 
            new Product(){ Id = 1, Name = "product 1 name", Description = "description"},
            new Product(){ Id = 2, Name = "product 2 name", Description = "description 2"}
        };
    }

    public void AddProdcut(Product product)
    {
        product.Id = _products.Count + 1;
        _products.Add(product);
    }

    public Product GetProductById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null) 
        {
            throw new KeyNotFoundException();
        }
        return product;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
}
