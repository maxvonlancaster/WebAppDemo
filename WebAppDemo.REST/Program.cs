using Microsoft.EntityFrameworkCore;
using WebAppDemo.REST.BLL.Interfaces;
using WebAppDemo.REST.BLL.Services;
using WebAppDemo.REST.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProductsService, ProductsService>();

builder.Services.AddDbContext<WebAppDemoContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppDemoConnection"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
