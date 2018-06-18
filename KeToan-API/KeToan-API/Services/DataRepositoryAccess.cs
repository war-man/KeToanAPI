using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public abstract class DataRepositoryAccess<T> : IDataRepository, IDataRepository<T>
        where T : class, new()
    {
        private IDbContextTransaction _transaction = null;
        public ILogger Logger { get; set; }
        public zModel Context { get; set; }

        public T AddEntity(T entity)
        {
            try
            {
                Context.AddAsync<T>(entity);
                return entity;
            }
            catch { return null; }
        }

        public IDbContextTransaction BeginTransaction()
        {
            try
            {
                if (_transaction == null)
                {
                    if (Context.Database.CurrentTransaction != null)
                        _transaction = Context.Database.CurrentTransaction;
                    else
                        _transaction = Context.Database.BeginTransaction();
                }
                return _transaction;
            }
            catch (Exception ex)
            {
                _transaction = null;
                Logger.LogError(new EventId(), ex, "Rollback Transaction");
                return null;
            }
        }

        public bool CommitTransaction()
        {
            try
            {
                if (_transaction == null)
                    return false;
                else
                {
                    _transaction.Commit();
                    _transaction = null;
                    return true;
                }
            }
            catch { return false; }
        }

        public async Task<IEnumerable<T>> GetEntity()
        {
            try
            {
                return await new zModel().Set<T>().ToListAsync();
            }
            catch { return null; }
        }

        public T GetEntity(int id)
        {
            try
            {
                return new zModel().Find<T>(id);
            }
            catch { return null; }
        }

        public bool RemoveEntity(int id)
        {
            try
            {
                var entity = Context.Find<T>(id);

                if (entity == null)
                    throw new IndexOutOfRangeException();
                else
                {
                    Context.Set<T>().Attach(entity).State = EntityState.Deleted;
                }
                return true;
            }
            catch { throw new IndexOutOfRangeException(); }
        }

        public bool RemoveEntity(T entity)
        {
            try
            {
                if (Context.Entry<T>(entity).GetDatabaseValues() == null)
                {
                    throw new IndexOutOfRangeException();
                }
                Context.Set<T>().Attach(entity).State = EntityState.Deleted;
                return true;
            }
            catch { throw new IndexOutOfRangeException(); }
        }

        public bool RollbackTransaction()
        {
            try
            {
                Context.Database.RollbackTransaction();
                _transaction.Dispose();
                DiscardAllChange();
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogError(new EventId(), ex, "Rollback Transaction");
                return false;
            }
        }

        public int SaveAll()
        {
            try
            {
                return Context.SaveChangesAsync().Result;
            }
            catch (Exception ex)
            {
                Logger.LogError(new EventId(), ex, "Save All");
                throw ex;
            }
        }

        public T UpdateEntity(T entity)
        {
            try
            {
                if (Context.Entry<T>(entity).GetDatabaseValues() == null)
                {
                    throw new IndexOutOfRangeException();
                }
                Context.Set<T>().Attach(entity).State = EntityState.Unchanged;
            }
            catch (Exception ex)
            {
                Logger.LogWarning(entity.GetType().Name, ex.Message);
            }
            var entry = Context.Set<T>().Attach(entity);
            
            
            Context.Update<T>(entity);
            return entity;
        }

        public bool DiscardAllChange()
        {
            try
            {
                foreach (var entry in Context.ChangeTracker.Entries<T>().Where(n => n.State == EntityState.Added || n.State == EntityState.Modified || n.State == EntityState.Deleted))
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                        case EntityState.Deleted:
                            entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                            entry.State = EntityState.Unchanged;
                            break;
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                        default:
                            break;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogError(new EventId(), ex, "Discard All Change");
                return false;
            }
        }

        public T DiscardChange(T entity)
        {
            try
            {
                var entry = Context.Entry(entity);
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    default:
                        break;
                }
                return entity;
            }
            catch (Exception ex)
            {
                Logger.LogError(new EventId(), ex, "Discard Change");
                return null;
            }
        }
    }
}
