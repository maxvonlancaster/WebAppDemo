using Microsoft.AspNetCore.Mvc;
using WebAppDemo.REST.BLL.Interfaces;
using WebAppDemo.REST.DAL.Entities;
using WebAppDemo.REST.Models;

namespace WebAppDemo.REST.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private IProductsService _productsService;

    public ProductsController(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpPost(Name = "AddProduct")]
    public async Task<Product> AddProduct(ProductDto productDto) 
    {
        return await _productsService.AddProdcut(productDto.ToProductEntity());
    }

    [HttpGet(Name = "GetProducts")]
    public async Task<IEnumerable<Product>> GetProductsAsync(int skip, int take) 
    {
        return await _productsService.GetProducts(skip, take);
    }
}
