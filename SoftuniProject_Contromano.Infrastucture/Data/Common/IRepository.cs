using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniProject_Contromano.Infrastucture.Data.Common
{
    public interface IRepository
    {
        IQueryable<TEntity> All<TEntity>() where TEntity : class;

        IQueryable<TEntity> AllReadOnlyAsync<TEntity>() where TEntity : class;

        Task AddAsync<TEntity>(TEntity entity) where TEntity : class;
        Task DeleteAsync<TEntity>(TEntity entity) where TEntity : class;
        Task SaveAsync<TEntity>(TEntity entity) where TEntity : class;
        Task DeleteAsync<TEntity>(int id) where TEntity : class;

        Task EditAsync<TEntity>(TEntity entity) where TEntity : class;

        Task<bool> CreateAsync<TEntity>(TEntity entity) where TEntity : class;
    }
}
