using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Services;

namespace XamarinApp.Pages
{
    public partial class ConfigurationPage : ContentPage
    {
        public ConfigurationPage()
        {
            InitializeComponent();
        }
        public async void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;

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
