
using System.Linq.Expressions;
using Core.Entities;

public interface IRepository<T>: IEntityBase where T: class,new()
{
    Task AddAsync(T entity);
    Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate = null,params Expression<Func<T,object>>[] includeproperties);

    Task<T> GetAsync(Expression<Func<T,bool>> predicate,params Expression<Func<T,object>>[] includeproperties);

    Task<T> GetByGuidAsync(Guid id);
    Task<T> UpdateAsync(T entity);

    Task DeleteAsync(T entity);

    Task<bool> AnyAsync(Expression<Func<T,bool>> predicate);
    Task<int> CountAsync(Expression<Func<T,bool>> predicate = null);

}
