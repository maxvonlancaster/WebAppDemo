using WebAppDemo.REST.DAL.Entities;

namespace WebAppDemo.REST.Models;

public class CategoryDto
{
    public string? Name { get; set; }

    public Category ToCategoryEntity() 
    {
        return new Category() { Name = this.Name };
    }
}
