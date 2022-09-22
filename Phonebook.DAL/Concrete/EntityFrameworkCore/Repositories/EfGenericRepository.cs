using Microsoft.EntityFrameworkCore;
using Phonebook.DAL.Concrete.EntityFrameworkCore.Context;
using Phonebook.DAL.Interfaces;
using System.Linq.Expressions;

namespace Phonebook.DAL.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, new()
    {
        public async Task<List<TEntity>> GetIncListAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().Include(keySelector).ToListAsync();
        }
        public async Task<List<TEntity>> GetIncListAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().Where(filter).Include(keySelector).ToListAsync();
        }
        public async Task<List<TEntity>> GetIncListAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, TKey>> keySelector2)
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().Where(filter).Include(keySelector).Include(keySelector2).ToListAsync();
        }
        public async Task<TEntity> GetIncAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().Where(filter).Include(keySelector).FirstOrDefaultAsync();
        }
        public async Task<TEntity> GetIncAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, TKey>> keySelector2)
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().Where(filter).Include(keySelector).Include(keySelector2).FirstOrDefaultAsync();
        }

        public async Task AddAsync(TEntity entity)
        {
            using var context = new PhonebookContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }
        public TEntity Add(TEntity entity)
        {
            using var context = new PhonebookContext();
            context.Add(entity);
            context.SaveChanges();

            return entity;
        }

        public List<TEntity> GetAll()
        {
            using var context = new PhonebookContext();
            return context.Set<TEntity>().ToList();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new PhonebookContext();
            return context.Set<TEntity>().Where(filter).ToList();
        }
        public List<TEntity> GetAll<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new PhonebookContext();
            return context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToList();
        }

        public List<TEntity> GetAll<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new PhonebookContext();
            return context.Set<TEntity>().OrderByDescending(keySelector).ToList();
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new PhonebookContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            using var context = new PhonebookContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using var context = new PhonebookContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(List<TEntity> entityList)
        {
            using var context = new PhonebookContext();
            await context.AddRangeAsync(entityList);
            await context.SaveChangesAsync();
        }

        public List<TEntity> AddRange(List<TEntity> entityList)
        {
            using var context = new PhonebookContext();
            context.AddRange(entityList);
            context.SaveChanges();

            return entityList;
        }

        public async Task RemoveRangeAsync(List<TEntity> entityList)
        {
            using var context = new PhonebookContext();
            context.RemoveRange(entityList);
            await context.SaveChangesAsync();
        }

        public void RemoveRange(List<TEntity> entityList)
        {
            using var context = new PhonebookContext();
            context.RemoveRange(entityList);
            context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            using var context = new PhonebookContext();
            context.Remove(entity);
            context.SaveChanges();
        }
    }
}
