using HS11PR001.Domain;
using HS11PR001.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Persistence;

public class ProductSystemDataContext : DbContext
{
    public ProductSystemDataContext(DbContextOptions<ProductSystemDataContext> options) : base(options)
    {       
    }

    public DbSet<Product> Products { get; set; }



    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach(var entry in ChangeTracker.Entries<BaseEntity>())
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreateDate = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdateDate = DateTime.Now;
                    break;
            }
        return base.SaveChangesAsync(cancellationToken);
    }
}
