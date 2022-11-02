using System.Linq.Expressions;
using mybooking.repository.Contract;

namespace mybooking.repository;

public class BaseRepository<T, TKey> : IBaseRepository<T, TKey> where T : class 
{
    public Task InsertAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task InsertAll(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task<T> FindById(TKey id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<T>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<T>> FindAsync(Expression<Func<T, bool>> expression, params string[] prop)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAll(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }
}