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
            CheckAppointments();
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

    }
}
