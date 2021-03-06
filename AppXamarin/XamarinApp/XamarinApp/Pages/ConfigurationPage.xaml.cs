﻿using PreSQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Models;
using XamarinApp.Services;

namespace XamarinApp.Pages
{
    public partial class ConfigurationPage : ContentPage
    {
        public ConfigurationPage()
        {
            InitializeComponent();
            using (var datos = new DataAccess())
            {
                var notification = datos.GetNotification();
                if(notification != null)
                    NotificationSwitch.IsToggled = notification.Active;
            }
        }
        public void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;

            var noti = new Notification
            {
                Id = 1,
                Active = e.Value

            };

            //Using cierra la conexión a la base de datos, una vez insertados los datos.
            using (var datos = new DataAccess())
            {
                if(datos.GetNotification() != null)
                    datos.UpdateNotification(noti);
                else
                    datos.InsertNotification(noti); //Inserta datos a la base de datos.
                
            }


            ////await DisplayAlert("Atención", "Las notificaciones se han guardado", "Entendido");

            //if (isToggled)
            //    await DisplayAlert("Atención", "Las notificaciones se han activado", "Entendido");

            //else
            //    await DisplayAlert("Atención", "Las notificaciones se han desactivado", "Entendido");


        }

    }
}
