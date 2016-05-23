using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinApp.Pages
{
    public partial class ScheduleAppointment : ContentPage
    {
        public ScheduleAppointment()
        {
            InitializeComponent();
        }
        public void DateSelectedEvent(object sender, DateChangedEventArgs e)
        {
            MainLabel.Text = "Cita para el dia " + e.NewDate.ToString();
        }
    }
}
