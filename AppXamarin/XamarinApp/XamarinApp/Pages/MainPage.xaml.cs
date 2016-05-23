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

            NavigationPage.SetHasBackButton(this, false);

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
                Hour = "10:00 am",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "11:00 am"
            });
            CitasListView.IsPullToRefreshEnabled = true;
            CitasListView.ItemsSource = CitasList;
        }

        public void Delete_OnClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            menuItem.IsDestructive = true;

            if (menuItem != null)
            {

                DisplayAlert("Alerta", "Cancelacion de "+ menuItem.CommandParameter.ToString(), "Ok");
                Citas listitem = (from itm in CitasList
                                  where itm.AppoimentTitle == menuItem.CommandParameter.ToString()
                                  select itm)
                   .FirstOrDefault<Citas>();
                CitasList.Remove(listitem);
            }
        }

        public async void OnItemSelected(object sender, EventArgs e)
        {
                 var detailPage = new InformationPageModal();

                 await Navigation.PushModalAsync(detailPage);
        }

    }
}
