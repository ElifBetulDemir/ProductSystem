using HS11PR001.Application.Contracts.Persistence.Repositories;
using HS11PR001.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity , new()
{
    protected readonly ProductSystemDataContext dataContext;
    public BaseRepository(ProductSystemDataContext dataContext)
        => this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));

    public async Task<bool> AddAsync(T entity, CancellationToken token)
    {
        await dataContext.Set<T>().AddAsync(entity, token);
        await dataContext.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken token)
        => await dataContext.Set<T>().Where(expression).ToListAsync(token);

    public async Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken token)
        => await dataContext.Set<T>().FirstOrDefaultAsync(expression, token) ?? throw new Exception($"{nameof(T)} Data Not Found!");
	public async Task<T> Update(T entity, CancellationToken token)
	{
		dataContext.Entry(entity).State = EntityState.Modified;
		//dataContext.Update(entity);
		dataContext.SaveChangesAsync();
		return entity;
	}
}
