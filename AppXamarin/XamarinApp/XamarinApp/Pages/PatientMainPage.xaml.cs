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
    public partial class PatientMainPage : ContentPage
    {
        public PatientMainPage()
        {
            InitializeComponent();
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
        }
        public async void AppointmentsClicked(object sender, EventArgs e)
        {
            ICollection<Appointment> appointments = new AppointmentService().GetAllAppointments();//change for web API
            var appointmentsListView = new AppointmentListView(appointments);
            await Navigation.PushAsync(appointmentsListView);
        }

        public async void ExpedientClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FileCaseSelectionP());
        }
    }
}
