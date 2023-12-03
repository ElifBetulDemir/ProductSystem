using HS11PR001.Application.Contracts.Persistence.Repositories;
using HS11PR001.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Persistence.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(ProductSystemDataContext dataContext) : base(dataContext)
    {  
    }
    public async Task<IEnumerable<Product>> GetAllByNameAsync(string name, CancellationToken token)
        => await base.GetAllAsync(g => g.Name.Contains(name), token);
}
