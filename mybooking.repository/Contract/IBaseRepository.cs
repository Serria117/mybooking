using System.Linq.Expressions;

namespace mybooking.repository.Contract;

public interface IBaseRepository<T, in TKey> where T : class
{
    Task InsertAsync(T entity);
    Task InsertAll(IEnumerable<T> entities);

    Task<T> FindById(TKey id);
    Task<IReadOnlyList<T>> GetAll();
    Task<IQueryable<T>> FindAsync(Expression<Func<T, bool>> expression, params string[] prop);

    Task UpdateAsync(T entity);
    Task UpdateAll(IEnumerable<T> entities);
}