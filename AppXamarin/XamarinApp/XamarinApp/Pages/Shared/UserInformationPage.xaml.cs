using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Models;


namespace XamarinApp.Pages
{
    public partial class UserInformationPage : ContentPage
    {
        

        public UserInformationPage(Patient user)
        {
            InitializeComponent();
            BindingContext = user;
        }

        public async void MedexpConfigurationClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigurationPage());
        }
    }


}
