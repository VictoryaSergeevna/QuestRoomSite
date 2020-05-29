using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba_14EntityASP.Models;

namespace Laba_14EntityASP.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        int Count { get; }
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);
        void Save();
    }
}
