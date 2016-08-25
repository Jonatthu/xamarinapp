using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.ViewModels;

namespace XamarinApp.Data
{
    public class PatientServices
    {
        public ExpedienteVm GetFileCase()
        {
            var userFileCase = new ExpedienteVm
            {
                Nombre = "Jose Manuel Alvarez",
                Edad = 20,
                CURP = "JOAAS1992123",
                GrupoEtnico = "Indigena",
                Religion = "Cristiano",
                TipoDeSangre = "O positivo",
                Discapacidad = "Ninguna",
                NivelSocioeconomico = "Medio"
            };
            return userFileCase;
        }
    }
}
