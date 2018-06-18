using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IRepositoryCollection
    {
        Repository<T> GetRepo<T>() where T : class, new();
    }

    public interface IDataRepository
    {
        zModel Context { get; set; }
        ILogger Logger { get; set; }
        int SaveAll();
        bool DiscardAllChange();
        IDbContextTransaction BeginTransaction();
        bool CommitTransaction();
        bool RollbackTransaction();

    }
    public interface IDataRepository<T> : IDataRepository
        where T : class, new()
    {
        T AddEntity(T entity);
        T UpdateEntity(T entity);
        bool RemoveEntity(T entity);

        bool RemoveEntity(int id);
        T DiscardChange(T entity);
        Task<IEnumerable<T>> GetEntity();
        T GetEntity(int id);
    }
}
