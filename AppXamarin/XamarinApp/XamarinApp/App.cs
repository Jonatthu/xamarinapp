using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using XamarinApp.Pages;
using XamarinApp.Pages.PatientViews;
using XamarinApp.Services;

namespace XamarinApp
{
    public class App : Application
    {
        public App()
        {
            //var nav = new NavigationPage(new PatientMainPage(new PatientService().GetPatientByUserId(1)));
            // The root page of your application
            //var nav = new NavigationPage(new DoctorMainPage(2));
            //nav.BarBackgroundColor = Color.FromHex("#222");
            //nav.BarTextColor = Color.White;
            var nav = new NavigationPage(new PatientMainPage(new PatientService().GetPatientByUserId(1)));
            //var nav = new NavigationPage(new FileCaseSelectionListView(1));
            MainPage = nav;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
