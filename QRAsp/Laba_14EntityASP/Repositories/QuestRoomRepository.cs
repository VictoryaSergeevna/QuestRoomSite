using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laba_14EntityASP.EF;
using Laba_14EntityASP.Models;
using System.Data.Entity;



namespace Laba_14EntityASP.Repositories
{
    public class QuestRoomRepository:IRepository<QuestRoom>
    {
        QRContext db;
        public QuestRoomRepository(QRContext context)
        {
            db = context;
        }
        public QuestRoomRepository()
        {
            db = new QRContext();
        }
        public int Count {
            get { return db.QuestRooms.Count(); }
        }

        

        public void Add(QuestRoom entity)
        {
            db.Entry(entity).State = EntityState.Added;
            Save();            
        }

        public void Delete(int id)
        {

            QuestRoom room = new QuestRoom { Id = id };
            db.Entry(room).State = EntityState.Deleted;
            Save();            
        }
        public void Delete(QuestRoom entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            Save();
        }

        public IEnumerable<QuestRoom> GetAll()
        {
            var ll = db.QuestRooms.ToList();
            return ll;
        }

        public QuestRoom GetById(int id)
        {
            return db.QuestRooms.Find(id);            
        }

        public void Update(QuestRoom entity)
        {
            db.Entry(entity).State =EntityState.Modified;
            Save();           
        }
        public void Save()
        {
            db.SaveChanges();
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
        // ~QuestRoomRepository() {
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