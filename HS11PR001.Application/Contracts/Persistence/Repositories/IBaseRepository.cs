using HS11PR001.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Application.Contracts.Persistence.Repositories;

public interface IBaseRepository<T> where T : BaseEntity, new()
{
    public Task<bool> AddAsync(T entity, CancellationToken token);
    public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken token);
    public Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken token);
	Task<T> Update(T entity, CancellationToken token);

}
