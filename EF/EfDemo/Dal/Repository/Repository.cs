using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dal.Domain;

namespace Dal.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class, IEntity
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext dbContext)
        {
            _context = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public TEntity GetById(int id, params Expression<Func<TEntity, object>>[] paths)
        {
            if (paths == null || !paths.Any())
            {
                return _dbSet.Find(id);
            }
            else
            {
                return this.Include(this.GetAll(), paths).FirstOrDefault(x => x.Id == id);
            }
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return GetQuery().Where(predicate);
        }

        public IQueryable<TEntity> GetAll()
        {
            return GetQuery();
        }

        public bool Contains(TEntity entity)
        {
            return GetById(entity.Id) != null;
        }

        public void Insert(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity", "Cannot add null entity.");
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity", "Cannot update null entity.");
            Attached(entity).State = EntityState.Modified;

        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            Delete(entity);
        }

        public void Delete(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity", "Cannot delete null entity.");
            Attached(entity).State = EntityState.Deleted;
        }

        public IQueryable<TEntity1> Include<TEntity1, TProperty>(IQueryable<TEntity1> source, params Expression<Func<TEntity1, TProperty>>[] paths) where TEntity1 : class
        {
            var ret = source;
            foreach (var expression in paths)
            {
                ret = ret.Include(expression);
            }
            return ret;
        }

        private DbQuery<TEntity> GetQuery()
        {
            DbQuery<TEntity> query = _dbSet;
            return query;
        }

        private DbEntityEntry<TEntity> Attached(TEntity entity)
        {
            var entry = _context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                var attachedEntity = _dbSet.Find(entity.Id);
                if (attachedEntity != null)
                {
                    var attachedEntry = _context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);
                    return attachedEntry;
                }
                else
                {
                    _dbSet.Attach(entity);
                }
            }

            return entry;
        }
    }
}
