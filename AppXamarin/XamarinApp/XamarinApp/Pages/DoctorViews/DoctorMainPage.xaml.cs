using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using XamarinApp.Services;

namespace XamarinApp.Pages
{
    public partial class DoctorMainPage : ContentPage
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }

        public DoctorMainPage(int DoctorId)
        {
            InitializeComponent();
            this.DoctorId = DoctorId;
            //GetDoctorNameByDoctorId()
            this.Title= "Juan Manuel Gonzalez Perez";
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");

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
    }
}
