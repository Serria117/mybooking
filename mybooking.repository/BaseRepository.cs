using System.Collections;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using mybooking.repository.Contract;
using mybooking.repository.DataContext;
using X.PagedList;

namespace mybooking.repository;

public class BaseRepository<T, TKey> : IBaseRepository<T, TKey> where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T>     _dbSet;
    public BaseRepository(AppDbContext context)
    {
        _context = context;
        _dbSet   = context.Set<T>();
    }

    public async Task InsertAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();

    }

    public async Task InsertAll(IEnumerable<T> entities)
    {
        await _dbSet.AddRangeAsync(entities);
        await _context.SaveChangesAsync();
    }

    public async Task<T?> FindById(TKey id)
    {
        var entity = await _dbSet.FindAsync(id);
        return entity;
    }

    public async Task<IPagedList<T>> GetAll(int page = 1, int size = 10)
    {
        return await _dbSet.ToPagedListAsync(page, size);
    }

    public async Task<IPagedList<T>> FindAsync(Expression<Func<T, bool>> expression, 
                                               int page = 1, int size = 2,
                                               params string[] prop)
    {
        var query = _dbSet.Where(expression);
        if (prop.Length > 0)
        {
            query = prop.Aggregate(query, (current, p) => current.Include(p));
        }

        return await query.ToPagedListAsync(page, size);
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAll(IEnumerable<T> entities)
    {
        _dbSet.UpdateRange(entities);
        await _context.SaveChangesAsync();
    }

    public async Task HardRemove(T entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task HardRemoveAll(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
        await _context.SaveChangesAsync();
    }
}