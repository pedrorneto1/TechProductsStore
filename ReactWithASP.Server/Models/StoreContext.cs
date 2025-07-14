using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tech_Products.Models;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;
}