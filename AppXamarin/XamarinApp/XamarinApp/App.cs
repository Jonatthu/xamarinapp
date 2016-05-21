using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using XamarinApp.Pages;

namespace XamarinApp
{
    public class App : Application
    {
        public App()
        {
            var nav = new NavigationPage(new LoginPage());
            // The root page of your application
            //nav.BarBackgroundColor = Color.FromHex("#222");
            //nav.BarTextColor = Color.White;
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
