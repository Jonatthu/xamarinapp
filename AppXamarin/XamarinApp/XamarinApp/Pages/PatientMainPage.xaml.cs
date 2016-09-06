using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinApp.Pages
{
    public partial class PatientMainPage : ContentPage
    {
        public PatientMainPage()
        {
            InitializeComponent();
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
        }
        public async void AppointmentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppointmentListView());
        }

        public async void ExpedientClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FileCaseSelectionP());
        }
    }
}
