using Microsoft.AspNetCore.Mvc;
using WebAppDemo.REST.BLL.Interfaces;
using WebAppDemo.REST.DAL.Entities;
using WebAppDemo.REST.Models;

namespace WebAppDemo.REST.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost(Name = "AddCategory")]
    public async Task<Category> AddCategory(CategoryDto categoryDto) 
    {
        return await _categoryService
            .AddCategory(categoryDto.ToCategoryEntity());
    }
}
