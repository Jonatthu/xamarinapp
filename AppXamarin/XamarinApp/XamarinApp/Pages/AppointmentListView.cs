using Xamarin.Forms;
using XamarinApp.Data;
using XamarinApp.Models;

namespace XamarinApp.Pages
{
    public class AppointmentListView:ContentPage
    {
        public AppointmentListView()
        {
            var greyColor = Color.FromHex("#262626");
            var fontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            var microFontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label));
            this.BackgroundColor =Color.FromHex("#f2f2f2");
            ListView listView = new ListView
            {
                SeparatorColor=greyColor,
                ItemsSource = new AppointmentServices().GetAllAppointments(),
                HasUnevenRows = false,
                RowHeight = 140,
                ItemTemplate = new DataTemplate(() =>
                {
                    #region items
                    
                    Label patientsNameLabel = new Label();
                    patientsNameLabel.TextColor = greyColor;
                    patientsNameLabel.FontAttributes = FontAttributes.Bold;
                    patientsNameLabel.FontSize = fontSize;
                    patientsNameLabel.SetBinding(Label.TextProperty,
                        new Binding("PatientName", BindingMode.OneWay, null, null, "Paciente: {0:N}"));
                    Image patientsImage = new Image();
                    patientsImage.SetBinding(Image.SourceProperty,
                        new Binding("ImageUrl", BindingMode.OneWay));
                    Label FolioLabel = new Label();
                    FolioLabel.TextColor = greyColor;
                    FolioLabel.FontSize = microFontSize;
                    FolioLabel.SetBinding(Label.TextProperty,
                        new Binding("Folio", BindingMode.OneWay, null, null, "Folio: {0:N}"));
                    Label SubjectLabel = new Label();
                    SubjectLabel.TextColor = greyColor;
                    SubjectLabel.FontSize = microFontSize;
                    SubjectLabel.SetBinding(Label.TextProperty,
                       new Binding("Subject", BindingMode.OneWay, null, null, "Asunto: {0:N}"));
                    Label StatusLabel = new Label();
                    StatusLabel.TextColor = greyColor;
                    StatusLabel.FontSize = microFontSize;
                    StatusLabel.SetBinding(Label.TextProperty,
                       new Binding("Status", BindingMode.OneWay, null, null, "Estatus: {0:N}"));
                    Label DateLabel = new Label();
                    DateLabel.TextColor = greyColor;
                    DateLabel.SetBinding(Label.TextProperty,
                        new Binding("Time", BindingMode.OneWay, null, null, "{0:MM/dd/yyyy a\\t h:mm tt}"));
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
                        Spacing = 10,
                        VerticalOptions = LayoutOptions.Center,
                        Children = {FolioLabel,SubjectLabel,StatusLabel}
                    };
                    StackLayout patientsInfoLayout = new StackLayout
                    {
                        Spacing = 5,
                        VerticalOptions = LayoutOptions.Center,
                        Children = { patientsNameLabel, horizontalLayout }
                    };
                    relativeLayout.Children.Add(patientsInfoLayout,
                        Constraint.RelativeToParent((Parent) => { return Parent.X + Parent.Width * .12; }),
                        Constraint.RelativeToParent((Parent) => { return (Parent.Y); }),
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
