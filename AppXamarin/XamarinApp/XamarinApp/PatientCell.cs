using System;
using Xamarin.Forms;

namespace XamarinApp
{
    public class PatientCell : ViewCell
    {
        public PatientCell()
        {
            var idEmpleadoLabel = new Label
            {
                HorizontalTextAlignment = TextAlignment.End,
                HorizontalOptions = LayoutOptions.Start,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
            };

            idEmpleadoLabel.SetBinding(Label.TextProperty, new Binding("Id"));

            var nombreCompetoLabel = new Label
            {
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.StartAndExpand
            };



            nombreCompetoLabel.SetBinding(Label.TextProperty, new Binding("Name"));


            var line1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                    idEmpleadoLabel, nombreCompetoLabel
                },
            };


            View = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    line1
                },
            };
        }
    }
}

