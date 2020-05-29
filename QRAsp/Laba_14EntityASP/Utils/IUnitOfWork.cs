using Laba_14EntityASP.Models;
using Laba_14EntityASP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_14EntityASP.Utils
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<QuestRoom> QuestRooms { get; }
        IRepository<Phone> Phones { get; }
        void Save();
    }
}
