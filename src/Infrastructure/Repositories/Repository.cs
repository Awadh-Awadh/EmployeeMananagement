using System.Linq.Expressions;
using Application.Common.Interfaces;
using Domain.Common;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T: BaseEntity<int>
{
    protected readonly AppDbContext _dbContext;
    private readonly ILogger _logger;

    /*
       we can make these method virtual and override them in the Entity repositories and use them based on how
        we want the implementation to be
     */
    
    public Repository(ILogger logger, AppDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }
    
    public async Task<IEnumerable<T>> FindAll(bool trackChanges)
    {
        return !trackChanges
            ? await _dbContext.Set<T>().AsNoTracking().ToListAsync()
            : await _dbContext.Set<T>().ToListAsync();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
    {
        return !trackChanges
            ? _dbContext.Set<T>().Where(expression).AsNoTracking()
            : _dbContext.Set<T>().Where(expression);
    }

    public async Task CreateAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
    }

    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
         await _dbContext.Set<T>().AddRangeAsync(entities);
    }

    public async Task UpdateAsync(T entity)
    {
        _dbContext.Set<T>().Update(entity);
    }

    public async Task DeleteAsync(T entity) => _dbContext.Set<T>().Remove(entity);
    
    public async Task DeleteRangeAsync(IEnumerable<T> entities)
    {
         _dbContext.Set<T>().RemoveRange(entities);
    }
}