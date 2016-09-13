using PreSQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Models;

namespace XamarinApp
{
    public partial class AddPatientPage : ContentPage
    {
        public AddPatientPage()
        {
            InitializeComponent();

            this.Padding = Device.OnPlatform(
                new Thickness(10, 20, 10, 10),  //Margenes para iOS
                new Thickness(10),              //Margenes para Android
                new Thickness(10)               //Margenes para Windows Phone
                 );

            listaListView.ItemTemplate = new DataTemplate(typeof(PatientCell));
            listaListView.RowHeight = 70;

            //using (var datos = new DataAccess())
            //{
            //    listaListView.ItemsSource = datos.GetPatients();       //Lista que muestra los datos guardados.
            //}

            agregarButton.Clicked += AgregarButton_Clicked;
        }

        private async void AgregarButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar nombres", "Aceptar");
                nombreEntry.Focus();
                return;
            }


            var paciente = new Patient
            {
                Name = nombreEntry.Text,
                Age = int.Parse(ageEntry.Text),
                Address = addressEntry.Text,
                BloodType = bloodtypeEntry.Text,
                CellphoneNumber = phoneEntry.Text,
                CURP = curpEntry.Text,
                //Email = emailEntry.Text,
                EmergencyNumber = emergencyNumberEntry.Text,
                //Hospital = hospitalEntry.Text,
                Religion = religionEntry.Text,
                //Username = usernameEntry.Text,
                //Password = passwordEntry.Text


            };

            //Using cierra la conexión a la base de datos, una vez insertados los datos.
            using (var datos = new DataAccess())
            {
                datos.InsertPatient(paciente); //Inserta datos a la base de datos.
                listaListView.ItemsSource = datos.GetPatients(); //Refresca la lista de pacientes.
            }

            //Vacía los formularios para una nueva captura.
            nombreEntry.Text = string.Empty;
            ageEntry.Text = string.Empty;
            addressEntry.Text = string.Empty;
            bloodtypeEntry.Text = string.Empty;
            phoneEntry.Text = string.Empty;
            curpEntry.Text = string.Empty;
            emailEntry.Text = string.Empty;
            emergencyNumberEntry.Text = string.Empty;
            hospitalEntry.Text = string.Empty;
            religionEntry.Text = string.Empty;
            usernameEntry.Text = string.Empty;
            passwordEntry.Text = string.Empty;

            await DisplayAlert("Confirmación", "Paciente agregado", "Aceptar");

        }
    }

}
