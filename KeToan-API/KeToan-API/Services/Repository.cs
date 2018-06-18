using System;

namespace API.Services
{
    public class Repository<T> : DataRepositoryAccess<T>, IDataRepository<T> where T : class, new()
    {
        public string RepositoryName { get; }
        public Repository(zModel context, Microsoft.Extensions.Logging.ILoggerFactory logger)
        {
            Type typeParameter = typeof(T);
            RepositoryName = typeParameter.Name;
            Context = context;
            Logger = logger.CreateLogger(RepositoryName);
        }
    }
    public class RepositoryCollection : IRepositoryCollection
    {
        private readonly zModel _context;
        private readonly Microsoft.Extensions.Logging.ILoggerFactory _logger;
        public RepositoryCollection(zModel context, Microsoft.Extensions.Logging.ILoggerFactory logger)
        {
            this._context = context;
            this._logger = logger;
        }
        public Repository<T> GetRepo<T>() where T : class, new()
        {
            return new Repository<T>(_context, _logger);
        }
    }
}
