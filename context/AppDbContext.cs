using CatalogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogApi.Context;

public class AppDbContext : DbContext {

    public AppDbContext(DbContextOptions<AppDbContext> options) : base ( options )
    {

    }

    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Produtos { get; set; }
}