using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Dal.Domain;

namespace Dal.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private readonly IComponentContext _container;

        private bool _disposed = false;

        public UnitOfWork(IComponentContext container, DbContext dbContext)
        {
            if (container == null) throw new ArgumentNullException("container");
            if (dbContext == null) throw new ArgumentNullException("dbContext");
            _container = container;
            _dbContext = dbContext;
        }

        public void Save()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    var details = new StringBuilder();

                    details.AppendFormat("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        details.AppendFormat("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                    }

                    //LoggingManager.Current.Error(details.ToString());
                }

                throw;
            }
            catch (Exception ex)
            {
                //LoggingManager.Current.Error("Exception occurred during saving changes from database context.", ex);
                throw;
            }
        }

        public IRepository<TEntity> Repository<TEntity>()
            where TEntity : class, IEntity
        {
            var repo = _container.Resolve<IRepository<TEntity>>(new TypedParameter(typeof(DbContext), _dbContext));
            return repo;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }

                this._disposed = true;
            }
        }
    }
}
