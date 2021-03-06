﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreSQLite;

using Xamarin.Forms;
using XamarinApp.Models;
using XamarinApp.Services;

namespace XamarinApp.Pages
{
    public partial class DoctorMainPage : ContentPage
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }

        public DoctorMainPage(Doctor doctor)
        {
            InitializeComponent();
            this.DoctorId = DoctorId;
            //GetDoctorNameByDoctorId()
            this.Title= doctor.Name;
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
            using (var datos = new DataAccess())
            {
                var notification = datos.GetNotification();
                if (notification != null)
                {
                    if(notification.Active == true)
                        CheckAppointments();
                }
            }
            
        }

        public async void PatientsClicked(object sender, EventArgs e)
        {   
            //CHANGE FOR WEB API GetPatientsByDoctorId()
            var patients = new PatientService().GetListOfPatients();
            await Navigation.PushAsync(new DoctorPatientsListView(patients));
            
        }

        public async void AppointmentClicked(object sender, EventArgs e)
        {
            var appointments = new AppointmentService().GetAllAppointments();
            await Navigation.PushAsync(new DoctorAppointmentsTabbedPage(1));
        }

        public async void MedexpConfigurationClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigurationPage());
        }

        public void CheckAppointments()
        {
            var appointments = new AppointmentService().GetAllAppointments().Where(s=> s.Status == "Pendiente");
            var tomorrow = DateTime.Now.AddDays(1);
            foreach (var item in appointments)
            {
                if(item.AppointmentDate.Month == DateTime.Now.Month)
                {
                    if((tomorrow.Day - item.AppointmentDate.Day) == 1)
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
