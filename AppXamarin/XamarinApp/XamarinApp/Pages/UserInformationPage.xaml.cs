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

        }
    }
}
