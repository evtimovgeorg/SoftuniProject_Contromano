using Microsoft.EntityFrameworkCore;
using SoftuniProject_Contromano.Infrastucture.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SoftuniProject_Contromano.Infrastucture.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        private DbSet<TEntity> DbSet<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>();
        }

        public IQueryable<TEntity> All<TEntity>() where TEntity : class
        {
            return DbSet<TEntity>();
        }

        public IQueryable<TEntity> AllReadOnlyAsync<TEntity>() where TEntity : class
        {
            return DbSet<TEntity>().AsNoTracking();
        }
        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public async Task SaveAsync<TEntity>(TEntity entity) where TEntity : class
        {
            
            await context.SaveChangesAsync();
        }
        private async Task Save()
        {
            await context.SaveChangesAsync();
        }
        public async Task EditAsync<TEntity>(TEntity entity) where TEntity : class
        {
           
        }

        public async Task DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            if ( entity is Article article)
            {
                article.IsDeleted = true;
            }
            else
            {
                DbSet<TEntity>().Remove(entity);
            }
            await Save();
        }

        public async Task DeleteAsync<TEntity>(int id) where TEntity : class
        {
            TEntity? entity = await GetByIdAsync<TEntity>(id);

            if (entity == null)
            {
                throw new InvalidOperationException($"Entity with id {id} does not exist.");
            }
            if (entity is Article article)
            {
                article.IsDeleted = true;
            }
            else
            {
                DbSet<TEntity>().Remove(entity);
            }
            await Save();

        }
        private async Task<TEntity> GetByIdAsync<TEntity>(int id) where TEntity : class
        {
            return await DbSet<TEntity>().FindAsync(id);
        }

        public async Task<bool> CreateAsync<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                await DbSet<TEntity>().AddAsync(entity);
                await Save();
                return true;
            }
            catch 
            {

                return false;
            }
        }

        
    }
}
