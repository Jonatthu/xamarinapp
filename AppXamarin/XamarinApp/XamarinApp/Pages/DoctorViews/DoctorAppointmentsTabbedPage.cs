using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Services;

namespace XamarinApp.Pages
{
    public class DoctorAppointmentsTabbedPage : TabbedPage
    {
        public DoctorAppointmentsTabbedPage(int userId)
        {
            var appointmentServices = new AppointmentService();
            var canceledAppointments = appointmentServices.GetAllAppointmentsByPatientId(1,"Cancelada");
            var attendedAppointments = appointmentServices.GetAllAppointmentsByPatientId(1, "Atendida");
            var upcomingAppointments = appointmentServices.GetAllAppointmentsByPatientId(1, "Pendiente");

            Page canceledAppointmentsPage = new DoctorAppointmentListView(canceledAppointments)
            {
                Title = "Canceladas",
                Icon = "logo.png"
            };
            Page attendedAppointmentsPage = new DoctorAppointmentListView(attendedAppointments)
            {
                Title = "Atendidas",
                Icon = "logo.png"
            };
            Page upcomingAppointmentsPage = new DoctorAppointmentListView(upcomingAppointments)
            {
                Title = "Pendientes",
                Icon = "logo.png"
            };
            Children.Add(upcomingAppointmentsPage);
            Children.Add(attendedAppointmentsPage);
            Children.Add(canceledAppointmentsPage);
        }
    }
}
