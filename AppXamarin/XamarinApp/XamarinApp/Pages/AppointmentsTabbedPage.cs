using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Services;

namespace XamarinApp.Pages
{
    public class AppointmentsTabbedPage : TabbedPage
    {
        public AppointmentsTabbedPage()
        {
            var appointmentServices = new AppointmentService();
            var canceledAppointments = appointmentServices.GetAllAppointments();
            var freeAppointments = appointmentServices.GetAllAppointments();
            Page canceledAppointmentsPage = new AppointmentListView(canceledAppointments);
            Page freeAppointmentsPage = new AppointmentListView(freeAppointments);
            canceledAppointmentsPage.Title = "Canceled";
            canceledAppointmentsPage.Icon = "logo.png";
            freeAppointmentsPage.Title = "Free";
            freeAppointmentsPage.Icon = "logo.png";

            Children.Add(freeAppointmentsPage);
            Children.Add(canceledAppointmentsPage);
        }
    }
}
