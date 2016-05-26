using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.ViewModels;

namespace XamarinApp.Pages
{
    public partial class UserInformationPage : ContentPage
    {
        public User user;

        public UserInformationPage()
        {
            InitializeComponent();
            user = new User();
            user.Name = "Jose";
            user.Age = 20;
            user.Address = "Privada Pamplona 6378 B52 Fraccionamiento Santa Fe 2da sección";
            user.CellphoneNumber = "6643864060";
            user.Email = "alvarez.m23@hotmail.com";
            user.Hospital = "ISSSTECALI";
            user.BloodType = "Rh positive";
            user.EmergencyNumber = "6642332760";

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new StackLayout  {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label  {
                                Text = "Paciente: " + user.Name + "\n" + "Edad: " + user.Age + "\n" + "Domicilio: " + user.Address
                                + "\n" + "Telefono Celular: " + user.CellphoneNumber + "\n" + "Correo Electrónico: " + user.Email
                                + "\n" + "Hospital: " + user.Hospital + "\n" + "Tipo de sangre: " + user.BloodType + "\n" +
                                "En caso de emergencia llamar al número :" + user.EmergencyNumber,
                                FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                                HorizontalOptions = LayoutOptions.FillAndExpand ,
                                HorizontalTextAlignment = TextAlignment.Center
                            },
                        }

                    }
                }
            };
        }
    }
}
