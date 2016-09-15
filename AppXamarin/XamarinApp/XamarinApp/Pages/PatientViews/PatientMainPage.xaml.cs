using PreSQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using XamarinApp.Models;
using XamarinApp.Pages;

using XamarinApp.Services;

namespace XamarinApp.Pages.PatientViews
{
    public partial class PatientMainPage : ContentPage
    {
        Patient patientLoggedIn { get; set; }

        public PatientMainPage(Patient patient)
        {
            InitializeComponent();
            patientLoggedIn = patient;
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
            Title = patient.Name;
            using (var datos = new DataAccess())
            {
                var notification = datos.GetNotification();
                if (notification != null)
                {
                    if (notification.Active == true)
                        CheckAppointments();
                }
            }
        }
        public async void AppointmentsClicked(object sender, EventArgs e)
        {
            var appointments = new AppointmentService().GetAllAppointmentsByPatientId(patientLoggedIn.Id, "Pendiente");
            var appointmentsListView = new PatientAppointmentListView(appointments);
            appointmentsListView.Title = "Citas";
            await Navigation.PushAsync(appointmentsListView);
        }

        public async void ExpedientClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FileCaseSelectionListView(patientLoggedIn.Id));
        }
        public async void MedexpConfigurationClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigurationPage());
        }

        public void CheckAppointments()
        {
            var appointments = new AppointmentService().GetAllAppointments().Where(s => s.Status == "Pendiente");
            var tomorrow = DateTime.Now.AddDays(1);
            foreach (var item in appointments)
            {
                if (item.AppointmentDate.Month == DateTime.Now.Month)
                {
                    if ((tomorrow.Day - item.AppointmentDate.Day) == 1)
                    {
                        DependencyService.Get<ILocalNotifications>().SendLocalNotification(
                       "Cita pendiente",
                       "Se cuenta con una cita programada para mañana, favor de estar al pendiente",
                       0
                       );
                    }
                }
            }
        }
        public async void SignOut(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Se ha cerrado sesión", "OK");
            App.Current.MainPage = new LoginPage();
        }

    }
}
