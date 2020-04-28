using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Electricity.DAL.Core.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity: class
    {
        internal DataContext _context;

        internal DbSet<TEntity> items => _context.Set<TEntity>();

        public Repository(DataContext context)
        {
            _context = context;
        }

        public TEntity Add( TEntity entity )
        {
            items.Add( entity );

            _context.SaveChanges();

            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {

            return _context.Set<TEntity>().AsQueryable();
        }

        public IQueryable<TEntity> GetAll( Expression<Func<TEntity, bool>> predicate )
        {
            return items.Where(predicate).AsNoTracking().AsQueryable();
        }

        public TEntity GetById( int id )
        {
            var entity = items.Find( id );

            return entity;
        }
    }
}
