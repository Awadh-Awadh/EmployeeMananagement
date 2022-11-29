using System.Linq.Expressions;

namespace Application.Common.Interfaces;

public interface IRepository<T>
{
    Task<IEnumerable<T>> FindAll(bool changeTracker);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool changeTracker);
    Task CreateAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task DeleteRangeAsync(IEnumerable<T> entities);
}