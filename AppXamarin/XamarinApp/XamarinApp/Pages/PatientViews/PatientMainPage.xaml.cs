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
    }
}
