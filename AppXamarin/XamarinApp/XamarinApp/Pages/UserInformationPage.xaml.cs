using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Data;
using XamarinApp.ViewModels;

namespace XamarinApp.Pages
{
    public partial class UserInformationPage : ContentPage
    {
        public User user;

        public UserInformationPage()
        {
            InitializeComponent();
            var FileCase = new PatientServices().GetFileCase();
            var Vm = new ExpedienteVm();
            double smallFontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            double LargeFontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            Vm.Nombre = FileCase.Nombre;
            Vm.Edad = FileCase.Edad;
            Vm.CURP = FileCase.CURP;
            Vm.GrupoEtnico = FileCase.GrupoEtnico;
            Vm.Religion = FileCase.Religion;
            Vm.TipoDeSangre = FileCase.TipoDeSangre;
            Vm.Discapacidad = FileCase.Discapacidad;
            Vm.NivelSocioeconomico = FileCase.NivelSocioeconomico;
            Vm.LargeFontSize = LargeFontSize;
            Vm.SmallFontSize = smallFontSize;
            BindingContext = Vm;

        
        }
    }
}
