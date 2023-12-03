using HS11PR001.Application.Contracts.Persistence.Repositories;
using HS11PR001.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProductSystemDataContext>(
            opt => opt.UseSqlServer(configuration.GetConnectionString("HS11PR"))
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IProductRepository,ProductRepository>();

        return services;
    }
}
