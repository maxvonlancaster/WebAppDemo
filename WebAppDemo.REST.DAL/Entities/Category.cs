using System.ComponentModel.DataAnnotations;

namespace WebAppDemo.REST.DAL.Entities;

public class Category
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }

    public ICollection<Product> Products { get; set; }
}
