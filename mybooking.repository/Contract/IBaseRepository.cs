using System.Linq.Expressions;
using X.PagedList;

namespace mybooking.repository.Contract;

public interface IBaseRepository<T, in TKey> where T : class
{
    Task InsertAsync(T entity);
    Task InsertAll(IEnumerable<T> entities);

    Task<T?> FindById(TKey id);
    Task<IPagedList<T>> GetAll(int page, int size);
    Task<IPagedList<T>> FindAsync(Expression<Func<T, bool>> expression, int page = 1, int size = 2, params string[] prop);

    Task UpdateAsync(T entity);
    Task UpdateAll(IEnumerable<T> entities);

    Task HardRemove(T entity);

    Task HardRemoveAll(IEnumerable<T> entities);
}