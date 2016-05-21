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
        public MainPage()
        {
            InitializeComponent();

            ObservableCollection<Citas> CitasList = new ObservableCollection<Citas>();
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
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasList.Add(new Citas
            {
                AppoimentTitle = "Inyeccion",
                Place = "Ensenada",
                DoctorName = "Doctor",
                Image = "http://icons.iconarchive.com/icons/grafikartes/flat-retro-modern/512/calendar-icon.png",
                Hour = "9:00 am"
            });
            CitasListView.ItemsSource = CitasList;
        }


    }
}
