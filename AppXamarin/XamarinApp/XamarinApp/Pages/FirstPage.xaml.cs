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
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            
            NavigationPage.SetHasBackButton(this, false);

        }
        public async void AppoinmentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        public async void InformationClicked(object sender, EventArgs e)
        {
            Patient patient = new PatientService().GetPatientByUserId(2);
            await Navigation.PushAsync(new UserInformationPage(patient));
        }

        public async void ScheduleAppointmentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScheduleAppointment());
        }

        public async void MedicinesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Medicines());
        }
    }
}
