using Phonebook.Business.Interfaces;
using Phonebook.DAL.Interfaces;
using System.Linq.Expressions;

namespace Phonebook.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, new()
    {
        IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<TEntity>> GetIncListAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            return await _genericDal.GetIncListAsync(filter, keySelector);
        }
        public async Task<List<TEntity>> GetIncListAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, TKey>> keySelector2)
        {
            return await _genericDal.GetIncListAsync(filter, keySelector, keySelector2);
        }
        public async Task<List<TEntity>> GetIncListAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            return await _genericDal.GetIncListAsync(keySelector);
        }
        public async Task AddAsync(TEntity entity)
        {
            await _genericDal.AddAsync(entity);
        }

        public TEntity Add(TEntity entity)
        {
            _genericDal.Add(entity);

            return entity;
        }
        public List<TEntity> GetAll()
        {
            return _genericDal.GetAll();
        }

        public List<TEntity> GetAll<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            return _genericDal.GetAll(keySelector);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return _genericDal.GetAll(filter);
        }

        public List<TEntity> GetAll<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            return _genericDal.GetAll(filter, keySelector);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _genericDal.GetAllAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            return await _genericDal.GetAllAsync(keySelector);
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _genericDal.GetAllAsync(filter);
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            return await _genericDal.GetAllAsync(filter, keySelector);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _genericDal.GetAsync(filter);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            await _genericDal.RemoveAsync(entity);
        }

        public void Remove(TEntity entity)
        {
            _genericDal.Remove(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _genericDal.UpdateAsync(entity);
        }

        public async Task<TEntity> GetIncAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            return await _genericDal.GetIncAsync(filter, keySelector);
        }

        public async Task<TEntity> GetIncAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, TKey>> keySelector2)
        {
            return await _genericDal.GetIncAsync(filter, keySelector, keySelector2);
        }

        public async Task AddRangeAsync(List<TEntity> entityList)
        {
            await _genericDal.AddRangeAsync(entityList);
        }

        public List<TEntity> AddRange(List<TEntity> entity)
        {
            _genericDal.AddRange(entity);

            return entity;
        }

        public async Task RemoveRangeAsync(List<TEntity> entityList)
        {
            await _genericDal.RemoveRangeAsync(entityList);
        }

        public void RemoveRange(List<TEntity> entityList)
        {
            _genericDal.RemoveRange(entityList);
        }
    }
}
