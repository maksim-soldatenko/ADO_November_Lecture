using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dal.Domain;

namespace Dal.Repository
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        TEntity GetById(int id, params Expression<Func<TEntity, object>>[] paths);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();

        bool Contains(TEntity entity);

        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);

        IQueryable<TEntity> Include<TEntity, TProperty>(IQueryable<TEntity> source, params Expression<Func<TEntity, TProperty>>[] paths) where TEntity : class;
    }
}
