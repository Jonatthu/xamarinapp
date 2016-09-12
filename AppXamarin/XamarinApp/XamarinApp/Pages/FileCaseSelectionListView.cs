using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Models;
using XamarinApp.Pages.PatientViews;
using XamarinApp.Services;

namespace XamarinApp.Pages
{
    public class FileCaseSelectionListView:ContentPage
    {
        public int UserId { get; set; }
        
        public FileCaseSelectionListView(int UserId)
        {
            this.UserId = UserId;
            Title = "Expediente";
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
            var greyColor = Color.FromHex("#262626");
            var fontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            List<string> options = new List<string> { "Datos Generales", "Historial de Citas" };

            ListView listView = new ListView
            {
                
                SeparatorColor = greyColor,
                ItemsSource = options,
                HasUnevenRows = false,
                RowHeight = 120,
                IsPullToRefreshEnabled = true
               
            };
            
            listView.ItemTapped += OptionSelected;
            listView.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
            };
            Content = listView;
        }

        private void OptionSelected(object sender,ItemTappedEventArgs e)
        {
            var list = (ListView)sender;
            if((string)e.Item =="Datos Generales") 
            {
                Patient patient = new PatientService().GetPatientByUserId(UserId);
                Navigation.PushAsync(new UserInformationPage(patient));
            }
            if((string)e.Item == "Historial de Citas")
            {
                Navigation.PushAsync(new PatientAppointmentsTabbedPage(UserId));
            }
           
            
        }
    }
}
