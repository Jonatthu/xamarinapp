using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Models;
using XamarinApp.Pages.PatientViews;
using XamarinApp.Services;
using XamarinApp.ViewModels;

namespace XamarinApp.Pages
{
    public partial class FileCaseSelectionForP : ContentPage
    {
        public int UserId { get; set; }
        public FileCaseSelectionForP(int UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
            Title = new PatientService().GetPatientNameByUserId(UserId);//CHANGE FOR API SERVICE
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
        }
        public async void PatientInfoClicked(object sender, EventArgs e)
        {
            Patient patient = new PatientService().GetPatientByUserId(UserId);//CHANGE FOR API SERVICE
            await Navigation.PushAsync(new UserInformationPage(patient));
        }

        public async void PatientAppointmentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PatientAppointmentsTabbedPage(1));
        }
    }
}
