using PreSQLite;
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
                NotificationSwitch.IsToggled = datos.GetNotification().Active;
            }
        }
        public async void Switch_OnToggled(object sender, ToggledEventArgs e)
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
                datos.InsertNotification(noti); //Inserta datos a la base de datos.
                datos.UpdateNotification(noti);
            }


            await DisplayAlert("Atención", "Las notificaciones se han guardado", "Entendido");

            if (isToggled)
            {
                DependencyService.Get<ILocalNotifications>().SendLocalNotification(
                    "Notification title",
                    "Notification content / description",
                    0
                );
                await DisplayAlert("Atención", "Las notificaciones se han activado", "Entendido");

            }
            else
                await DisplayAlert("Atención", "Las notificaciones se han desactivado", "Entendido");


        }

    }
}
