using Android;
using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinApp.Pages
{
    public partial class LoginPage : ContentPage
    {

        public string UsernameE = "Odasoft";
        public string PasswordE = "p4ssw0rd";

        public LoginPage()
        {
            InitializeComponent();
        }

        public async void SignInPressed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text))
            {
                await DisplayAlert("Alerta", "Ingrese nombre de usuario", "Aceptar");
                Username.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Alerta", "Ingrese contraseña", "Aceptar");
                Password.Focus();
                return;
            }

            if (UsernameE.Equals(Username.Text) && PasswordE.Equals(Password.Text))
            {
                waitActivityIndicator.IsRunning = true;
                await Task.Delay(3000);
                await Navigation.PushAsync(new FirstPage());
                waitActivityIndicator.IsRunning = false;
                Username.Text = string.Empty;
                Password.Text = string.Empty;
            }
            else
            {
                await DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Aceptar");
                Username.Text = string.Empty;
                Password.Text = string.Empty;
                return;
            }
        }
    }
}
