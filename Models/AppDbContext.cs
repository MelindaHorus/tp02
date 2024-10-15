using System.Collections.Generic;
using System.Data.Entity;

public class AppDbContext : DbContext
{
    public DbSet<BL> BLs { get; set; }
    public DbSet<Container> Containers { get; set; }

    public AppDbContext() : base("DefaultConnection")
    {
    }
}
