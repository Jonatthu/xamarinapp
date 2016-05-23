using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.ViewModels;

namespace XamarinApp.Pages
{
    public partial class InformationPageModal : ContentPage
    {
        public User user;
        public InformationPageModal()
        {
            InitializeComponent();
            user = new User();
            user.Name = "Jose";
            user.Age = 20;
            user.Address = "Privada Pamplona 6378 B52 Fraccionamiento Santa Fe 2da sección";
            user.CellphoneNumber = "6643864060";
            user.Email = "alvarez.m23@hotmail.com";
            user.Hospital = "ISSSTECALI";
            user.BloodType = "Rh positive";
            user.EmergencyNumber = "6642332760";
            var nameLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };
            nameLabel.SetBinding(Label.TextProperty, "Name");
            var dismissButton = new Button { Text = "Dismiss" };
            dismissButton.Clicked += OnDismissButtonClicked;

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                new StackLayout {
                Orientation = StackOrientation.Horizontal,
                Children = {
                    new Label{ Text = "Nombre:", FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)), HorizontalOptions = LayoutOptions.FillAndExpand },
                    nameLabel
                            }
             },
                dismissButton
              }
            };
        }
        public async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
