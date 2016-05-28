using Android;
using Android.App;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Pages;
using XamarinApp.Services;
using XamarinApp.ViewModels;

namespace XamarinApp.Pages
{
    public partial class LoginPage : ContentPage
    {

        UserService _userService = new UserService();

        public LoginPage()
        {
            InitializeComponent();
        }

        public async void GetUserPressed(object o, EventArgs e)
        {
            var _userService = new UserService();
            var user = _userService.GetUser(1);
            await DisplayAlert("This User is", $"I'm {user.Username} with the password: {user.Password}", "Ok End");
        }

        public async void ForgetPasswordMethod(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Aun no estoy implementado", "Ok");
        }

        public async void SignInPressed(object sender, EventArgs e)
        {
            var user = _userService.GetUser(1);

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

            if (user.Username.Equals(Username.Text) &&  user.Password.Equals(Password.Text))
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
