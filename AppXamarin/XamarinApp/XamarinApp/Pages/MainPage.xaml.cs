using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Citas> CitasList { get; set; }
        public MainPage()
        {
            InitializeComponent();

            CitasList = new ObservableCollection<Citas>();
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Endodoncia",
                Place = "Tijuana",
                DoctorName = "Doctor",
                Hour = "9:00 am",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Cirugia",
                Place = "Mexicali",
                DoctorName = "Doctor",
                Hour = "9:00 am",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasListView.IsPullToRefreshEnabled = true;
            CitasListView.ItemsSource = CitasList;
        }

        public void Delete_OnClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;

            if (menuItem != null)
            {
                var name = menuItem.BindingContext as string;
                DisplayAlert("Alerta", "La cita se cancelará" + name, "Ok");
                Citas listitem = (from itm in CitasList
                                  where itm.AppoimentTitle == menuItem.CommandParameter.ToString()
                                  select itm)
                   .FirstOrDefault<Citas>();
                CitasList.Remove(listitem);
            }
        }

    }
}
