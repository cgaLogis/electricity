using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Electricity.DAL.Core.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAll( Expression<Func<TEntity, bool>> predicate );

        TEntity GetById( int id );

        TEntity Add( TEntity entity );
    }
}
