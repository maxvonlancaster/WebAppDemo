using WebAppDemo.REST.DAL.Entities;

namespace WebAppDemo.REST.Models;

public class ProductDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime? ShippingDate { get; set; }
    public int CategoryId { get; set; }

    public Product ToProductEntity() 
    {
        return new Product { 
            Name = Name, Description = Description, 
            ShippingDate = ShippingDate ?? DateTime.Now, CategoryId = CategoryId };
    }
}
