using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp.Pages
{
    public class FileCaseSelection:ContentPage
    {

        Dictionary<string, string> buttonDictionary;
        static List<string> buttonSource;
        double mediumFontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button));
        Color grayColor = Color.FromHex("#f2f2f2");
        Color separatorColor = Color.Gray;
        Color backGroundColor = Color.FromHex("#262626");
        int rowHeight = 80;

        public FileCaseSelection()
        {
            Title = "Expediente";
            buttonDictionary = new Dictionary<string, string>
            {
                { "Datos Generales","GeneralInfoClicked" },{"Citas","" }
            };
            buttonSource = new List<string>();

            foreach (var value in buttonDictionary)
            {
                buttonSource.Add(value.Key);
            }
            var listView = new ListView();
            listView.SeparatorColor = separatorColor;
            listView.ItemsSource = buttonSource;
            listView.RowHeight = rowHeight;
            
            
            Content = new StackLayout
            {
                BackgroundColor= backGroundColor,
                Children = { listView}
            };

           

        }


    }
}
