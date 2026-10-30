using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using CarpenterOrdersManagmentSystem.Models;

public class CarpenterOrdersContext : DbContext
{
    public DbSet<Product> Products {get;set;}
    
    public CarpenterOrdersContext(DbContextOptions options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=carpenter_orders;User Id=sa;Password=@dm1N123!;TrustServerCertificate=True;MultipleActiveResultSets=true;");
        }
    }
}