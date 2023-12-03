using HS11PR001.Application.Features.Products.ViewModels;
using HS11PR001.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Application.Contracts.Persistence.Repositories;

public interface IProductRepository : IBaseRepository<Product>
{
    Task<IEnumerable<Product>> GetAllByNameAsync(string name,CancellationToken token);
}
