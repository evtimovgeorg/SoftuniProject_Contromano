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

        IQueryable<TEntity> AllReadOnly<TEntity>() where TEntity : class;
    }
}
