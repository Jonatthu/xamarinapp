using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using Xamarin.Forms;
using XamarinApp;
using XamarinApp.Models;

namespace PreSQLite
{
    public class DataAccess : IDisposable
    {
        private SQLiteConnection connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma,
                System.IO.Path.Combine(config.DirectorioDB, "Notifications.db3"));
            connection.CreateTable<Notification>();
        }
        #region Notification
        public void InsertNotification(Notification notification)
        {
            connection.Insert(notification);
        }

        public void UpdateNotification(Notification notification)
        {
            connection.Update(notification);
        }
        public Notification GetNotification()
        {
            return connection.Table<Notification>().FirstOrDefault();
        }
        #endregion

        public void InsertPatient(Patient empleado)
        {
            connection.Insert(empleado);
        }


        public void UpdatePatient(Patient empleado)
        {
            connection.Update(empleado);
        }

        public void DeletePatient(Patient empleado)
        {
            connection.Delete(empleado);
        }

        public Patient GetPatient(int IDEmpleado)
        {
            return connection.Table<Patient>().FirstOrDefault(c => c.Id == IDEmpleado);
        }

        public List<Patient> GetPatients()
        {
            return connection.Table<Patient>().OrderBy(c => c.Name).ToList();
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}

