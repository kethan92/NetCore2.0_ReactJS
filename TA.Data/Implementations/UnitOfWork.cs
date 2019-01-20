using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TA.Data.Interfaces;

namespace TA.Data.Implementations
{
    public class UnitOfWork<TContext> : IRepositoryFactory, IUnitOfWork<TContext>, IUnitOfWork where TContext: DbContext
    {
        private Dictionary<System.Type, object> _repositories;
        public UnitOfWork(TContext context)
        {
            Context = context ?? throw new ArgumentException(nameof(context));
        }

        public TContext Context { get; }

        public void Dispose()
        {
            Context?.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Dictionary<System.Type, object>();

            var type = typeof(T);
            if (!_repositories.ContainsKey(type))
                _repositories[type] = new GenericRepository<T>(Context);
            return (IRepository<T>)_repositories[type];
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
    }
}
