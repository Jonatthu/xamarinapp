using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Models;

namespace XamarinApp.Pages.PatientViews
{
    public class PatientAppointmentListView:ContentPage
    {
        public PatientAppointmentListView(ICollection<Appointment> _Appointments)
        {
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
            var greyColor = Color.FromHex("#262626");
            var fontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            var microFontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label));
            this.BackgroundColor = Color.FromHex("#f2f2f2");
            ListView listView = new ListView
            {
                SeparatorColor = greyColor,
                ItemsSource = _Appointments,
                HasUnevenRows = false,
                RowHeight = 180,
                ItemTemplate = new DataTemplate(() =>
                {
                    #region items

                    Label patientsNameLabel = new Label();
                    patientsNameLabel.TextColor = greyColor;
                    patientsNameLabel.FontAttributes = FontAttributes.Bold;
                    patientsNameLabel.FontSize = fontSize;
                    patientsNameLabel.SetBinding(Label.TextProperty,
                        new Binding("Doctor.Name", BindingMode.OneWay, null, null, "Doctor: {0:N}"));
                    Image patientsImage = new Image();
                    patientsImage.SetBinding(Image.SourceProperty,
                        new Binding("Doctor.Photo", BindingMode.OneWay));
                    Label FolioLabel = new Label();
                    FolioLabel.TextColor = greyColor;
                    FolioLabel.FontSize = microFontSize;
                    FolioLabel.SetBinding(Label.TextProperty,
                        new Binding("Doctor.CellphoneNumber", BindingMode.OneWay, null, null, "Celular: {0:N}"));
                    Label CellPhoneNumberLabel = new Label();
                    CellPhoneNumberLabel.TextColor = greyColor;
                    CellPhoneNumberLabel.FontSize = microFontSize;
                    CellPhoneNumberLabel.SetBinding(Label.TextProperty,
                       new Binding("Type", BindingMode.OneWay, null, null, "Asunto: {0:N}"));
                    Label StatusLabel = new Label();
                    StatusLabel.TextColor = greyColor;
                    StatusLabel.FontSize = microFontSize;
                    StatusLabel.SetBinding(Label.TextProperty,
                       new Binding("Status", BindingMode.OneWay, null, null, "Estatus: {0:N}"));
                    Label DateLabel = new Label();
                    DateLabel.TextColor = greyColor;
                    DateLabel.SetBinding(Label.TextProperty,
                        new Binding("AppointmentDate", BindingMode.OneWay, null, null, "{0:MM/dd/yyyy a\\t h:mm tt}"));
                    #endregion


                    RelativeLayout relativeLayout = new RelativeLayout();

                    relativeLayout.VerticalOptions = LayoutOptions.Center;
                    //relativeLayout.Children.Add(patientsImage,
                    //    Constraint.RelativeToParent((Parent) => { return Parent.X; }),
                    //    Constraint.RelativeToParent((Parent) => { return (Parent.Y); }),
                    //    Constraint.RelativeToParent((Parent) => { return Parent.Width * .12; }),
                    //    Constraint.RelativeToParent((Parent) => { return Parent.Height * .8; })
                    //    );


                    StackLayout horizontalLayout = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Spacing = 20,
                        VerticalOptions = LayoutOptions.Center,
                        Children = { FolioLabel, CellPhoneNumberLabel, StatusLabel }
                    };
                    StackLayout patientsInfoLayout = new StackLayout
                    {
                        Spacing = 15,
                        VerticalOptions = LayoutOptions.Center,
                        Children = { patientsNameLabel, horizontalLayout }
                    };
                    relativeLayout.Children.Add(patientsInfoLayout,
                        Constraint.RelativeToParent((Parent) => { return Parent.X + Parent.Width * .14; }),
                        Constraint.RelativeToParent((Parent) => { return (Parent.Y + Parent.Height * .24); }),
                        Constraint.RelativeToParent((Parent) => { return Parent.Width * .80; }),
                        Constraint.RelativeToParent((Parent) => { return Parent.Height; })
                        );
                    relativeLayout.Children.Add(DateLabel,
                        Constraint.RelativeToParent((Parent) => { return Parent.X + Parent.Width * .50; }),
                        Constraint.RelativeToParent((Parent) => { return (Parent.Y + Parent.Height * .70); }),
                        Constraint.RelativeToParent((Parent) => { return Parent.Width * .80; }),
                        Constraint.RelativeToParent((Parent) => { return Parent.Height; })
                        );


                    return new ViewCell
                    {
                        View = relativeLayout
                    };
                })
            };
            this.Content = new StackLayout
            {
                Children = { listView }
            };

        }
    }
}
