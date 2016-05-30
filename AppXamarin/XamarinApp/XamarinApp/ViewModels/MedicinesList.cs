using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.ViewModels
{
    public class MedicinesList
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string PillImage { get; set; }

        /*
        public List<MedicinesList> ListOfMedicines{
            get
            {
                return new List<MedicinesList>
                {
                    new MedicinesList {Name = "Cadflo capsules", Date = DateTime.Today, Hour = DateTime.Now.ToString("{HH:mm:ss tt}") },
                    new MedicinesList {Name = "Fludac capsules", Date = DateTime.Today, Hour = DateTime.Now.ToString("{HH:mm:ss tt}") },
                    new MedicinesList {Name = "Alerid tablets", Date = DateTime.Today, Hour = DateTime.Now.ToString("{HH:mm:ss tt}") },
                    new MedicinesList {Name = "Lanzoc-30capsules", Date = DateTime.Today, Hour = DateTime.Now.ToString("{HH:mm:ss tt}") }
                };
            }
        }
        */
    }
}
