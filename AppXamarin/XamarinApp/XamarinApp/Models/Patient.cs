using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Models
{
    public class Patient:User
    {

        public string Religion { get; set; }
        public string Disability { get; set; }
        public string  SocioEconomicLevel { get; set; }
        public string EthnicGroup { get; set; }
    }
}
