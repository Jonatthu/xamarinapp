using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.ViewModels
{
    public class ExpedienteVm: ViewModel
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string CURP { get; set; }
        public string GrupoEtnico { get; set; }
        public string Religion { get; set; }
        public string TipoDeSangre { get; set; }
        public string Discapacidad { get; set; }
        public string NivelSocioeconomico { get; set; }
        
    }
}
