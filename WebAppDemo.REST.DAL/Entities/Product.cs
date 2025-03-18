using System.ComponentModel.DataAnnotations;

namespace WebAppDemo.REST.DAL.Entities;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime ShippingDate { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
