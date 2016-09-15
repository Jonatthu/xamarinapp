
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Models;
using XamarinApp.Pages;
using XamarinApp.Pages.PatientViews;
using XamarinApp.Services;
using XamarinApp.ViewModels;

namespace XamarinApp.Pages
{
    public partial class LoginPage : ContentPage
    {

        AccountsService _userService = new AccountsService();
        


        public LoginPage()
        {
            InitializeComponent();
        }

        

        public async void ForgetPasswordMethod(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Aun no estoy implementado", "Ok");
        }

        public async void SignInPressed(object sender, EventArgs e)
        {
            var service = new AccountsService();

            if (string.IsNullOrEmpty(UsernameEntry.Text))
            {
                await DisplayAlert("Alerta", "Ingrese nombre de usuario", "Aceptar");
                UsernameEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(PasswordEntry.Text))
            {
                await DisplayAlert("Alerta", "Ingrese contraseña", "Aceptar");
                PasswordEntry.Focus();
                return;
            }

            if (service.Authentication(UsernameEntry.Text,PasswordEntry.Text))
            { 
                waitActivityIndicator.IsRunning = true;
                await Task.Delay(1500);

                if(service.GetUserNameType(UsernameEntry.Text)=="Paciente")
                {
                    Patient patient = service.GetPatientByUserId(1);
                    App.Current.MainPage = new NavigationPage(new PatientMainPage(patient));
                }
                else if(service.GetUserNameType(UsernameEntry.Text)=="Doctor")
                {
                    Doctor doctor = service.GetDoctorByUserId(1);
                    App.Current.MainPage = new NavigationPage(new DoctorMainPage(doctor));
                }
                
                waitActivityIndicator.IsRunning = false;
                UsernameEntry.Text = string.Empty;
                PasswordEntry.Text = string.Empty;
            }
            else
            {
                await DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Aceptar");
                PasswordEntry.Text = string.Empty;
                return;
            }
        }
    }
}
