using System.Linq.Expressions;

namespace Phonebook.DAL.Interfaces
{
    public interface IGenericDal<TEntity> where TEntity : class, new()
    {
        Task<List<TEntity>> GetIncListAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector);
        Task<List<TEntity>> GetIncListAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector);
        Task<List<TEntity>> GetIncListAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, TKey>> keySelector2);
        List<TEntity> GetAll();
        List<TEntity> GetAll<TKey>(Expression<Func<TEntity, TKey>> keySelector);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector);
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter);
        Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector);
        Task<TEntity> GetIncAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector);
        Task<TEntity> GetIncAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, TKey>> keySelector2);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(List<TEntity> entityList);
        List<TEntity> AddRange(List<TEntity> entityList);
        TEntity Add(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        void Remove(TEntity entity);
        Task RemoveRangeAsync(List<TEntity> entityList);
        void RemoveRange(List<TEntity> entityList);
    }
}
