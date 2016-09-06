using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Services;

namespace XamarinApp.Pages
{
    public partial class AppointmentInformation : ContentPage
    {
        public AppointmentInformation()
        {

            AppointmentService service = new AppointmentService();
            InitializeComponent();

            var appointments = service.GetAllAppointments().Where(a => a.AppointmentId == 1).FirstOrDefault();

            //Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            //Content = new StackLayout
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Children = {
            //        new StackLayout  {
            //            Orientation = StackOrientation.Horizontal,
            //            Children =
            //            {
            //                new Label  {
            //                    Text = "Nombre \n" + appointments.Patient.Name + "\n\n" +
            //                            "CURP \n" + appointments.Patient.CURP + "\n\n"+
            //                            "Religion \n" + appointments.Patient.Religion + "\n\n" +
            //                            "Discapacidad \n" + appointments.Patient.Service + "\n\n" +
            //                            "Datos \n" + appointments.Patient.Service + "\n\n" +
            //                            "Datos \n" + appointments.Patient.Service,
            //                    FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
            //                    HorizontalOptions = LayoutOptions.FillAndExpand ,
            //                    HorizontalTextAlignment = TextAlignment.Start
            //                },
            //                new Label
            //                {
            //                     Text = "Edad \n" + appointments.Patient.Age + "\n\n"+
            //                            "Grupo etnico \n" + appointments.Patient.Service + "\n\n" +
            //                            "Tipo de sangre \n" +  appointments.Patient.BloodType + "\n\n" +
            //                            "Nivel socioeconomico \n" + appointments.Patient.Service + "\n\n" +
            //                            "Datos \n" + appointments.Patient.Address + "\n\n" +
            //                            "Datos \n" + appointments.Severity,
            //                    FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
            //                    HorizontalOptions = LayoutOptions.FillAndExpand ,
            //                    HorizontalTextAlignment = TextAlignment.Start
            //                }
            //            }

            //        }
            //    }
            //};
        }
    }
}
