using Laba_14EntityASP.EF;
using Laba_14EntityASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Laba_14EntityASP.Repositories
{
    public class PhoneRepository : IRepository<Phone>
    {
        QRContext db;
        public PhoneRepository(QRContext context)
        {
            db = context;
        }
        public PhoneRepository()
        {
            db = new QRContext();
        }
        public int Count { get { return db.Phones.Count(); } }

        public void Add(Phone entity)
        {
            db.Entry(entity).State = EntityState.Added;
            Save();
        }

        public void Delete(int id)
        {
           Phone ph = new Phone { Id = id };
            db.Entry(ph).State = EntityState.Deleted;
            Save();
        }

        public void Delete(Phone entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            Save();
        }

        public IEnumerable<Phone> GetAll()
        {
            var ll = db.Phones.ToList();
            return ll;
        }

        public Phone GetById(int id)
        {
            return db.Phones.Find(id);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Phone entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            Save();
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
        // ~PhoneRepository() {
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