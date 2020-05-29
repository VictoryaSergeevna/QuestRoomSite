using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laba_14EntityASP.EF;
using Laba_14EntityASP.Models;
using Laba_14EntityASP.Repositories;

namespace Laba_14EntityASP.Utils
{
    public class EFUnitOfWork : IUnitOfWork
    {
         IRepository<QuestRoom> questRooms;
         IRepository<Phone> phones;
        private QRContext context = new QRContext();



        public IRepository<QuestRoom> QuestRooms
        {
            get
            {
                if (questRooms == null)
                    questRooms = new QuestRoomRepository(context);
                return questRooms;
            }
        }
        public IRepository<Phone> Phones
        {
            get
            {
                if (phones == null)
                    phones = new PhoneRepository(context);
                return phones;
            }
        }
       

        public void Save()
        {
            context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~EFUnitOfWork() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}