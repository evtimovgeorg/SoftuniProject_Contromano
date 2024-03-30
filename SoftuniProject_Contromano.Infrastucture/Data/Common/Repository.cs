using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniProject_Contromano.Infrastucture.Data.Common
{
    public class Repository : IRepository
    {
        public IQueryable<TEntity> All<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> AllReadOnly<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
