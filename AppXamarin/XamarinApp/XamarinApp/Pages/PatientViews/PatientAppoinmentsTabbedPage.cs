using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Services;

namespace XamarinApp.Pages.PatientViews
{
    public class PatientAppointmentsTabbedPage : TabbedPage
    {
        public PatientAppointmentsTabbedPage(int userId)
        {
            var appointmentServices = new AppointmentService();
            var canceledAppointments = appointmentServices.GetAllAppointmentsByPatientId(1, "Cancelada");
            var attendedAppointments = appointmentServices.GetAllAppointmentsByPatientId(1, "Atendida");
            var upcomingAppointments = appointmentServices.GetAllAppointmentsByPatientId(1, "Pendiente");

            Page canceledAppointmentsPage = new PatientAppointmentListView(canceledAppointments)
            {
                Title = "Canceladas",
                Icon = "logo.png"
            };
            Page attendedAppointmentsPage = new PatientAppointmentListView(attendedAppointments)
            {
                Title = "Atendidas",
                Icon = "logo.png"
            };
            Page upcomingAppointmentsPage = new PatientAppointmentListView(upcomingAppointments)
            {
                Title = "Pendientes",
                Icon = "logo.png"
            };

            Children.Add(attendedAppointmentsPage);
            Children.Add(canceledAppointmentsPage);
            Children.Add(upcomingAppointmentsPage);
        }
    }
}
