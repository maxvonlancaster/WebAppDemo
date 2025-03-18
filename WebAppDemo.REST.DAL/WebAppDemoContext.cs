using Microsoft.EntityFrameworkCore;
using WebAppDemo.REST.DAL.Entities;

namespace WebAppDemo.REST.DAL;

public class WebAppDemoContext : DbContext
{
    public WebAppDemoContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    // we have model first approach (another one database first approach)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);

        //base.OnModelCreating(modelBuilder);
    }
}
