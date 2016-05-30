using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.ViewModels;

namespace XamarinApp.Pages
{
    public partial class Medicines : ContentPage
    {
        public ObservableCollection<MedicinesList> MedList { get; set; }

        public Medicines()
        {
            /*
            MedList = new MedicinesList();
            MedicinesListView.IsPullToRefreshEnabled = true;
            MedicinesListView.ItemsSource = MedList.ListOfMedicines;
            */
            InitializeComponent();

            MedList = new ObservableCollection<MedicinesList>();
            MedList.Add(new MedicinesList
            {
                Name = "Cadflo capsules",
                Date = DateTime.Now.ToString("dd/MM/yyyy"),
                Hour = DateTime.Now.ToString("HH:mm:ss"),
                PillImage = "http://icons.iconarchive.com/icons/flat-icons.com/square/512/pill-icon.png"
            });
            MedList.Add(new MedicinesList
            {
                Name = "Fludac capsules",
                Date = DateTime.Now.ToString("dd/MM/yyyy"),
                Hour = DateTime.Now.ToString("HH:mm:ss tt"),
                PillImage = "http://icons.iconarchive.com/icons/flat-icons.com/square/512/pill-icon.png"
            });
            MedList.Add(new MedicinesList
            {
                Name = "Alerid capsules",
                Date = DateTime.Now.ToString("dd/MM/yyyy"),
                Hour = DateTime.Now.ToString("HH:mm:ss tt"),
                PillImage = "http://icons.iconarchive.com/icons/flat-icons.com/square/512/pill-icon.png"
            });
            MedicinesListView.IsPullToRefreshEnabled = true;
            MedicinesListView.ItemsSource = MedList;
        }

        public void OnItemTapped (object o, ItemTappedEventArgs e)
        {
            var med = e.Item as Medicines;
            DisplayAlert("Selección realizada","Tocaste en ...","Ok");
        }
    }
}
