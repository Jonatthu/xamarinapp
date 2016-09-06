using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Models
{
    public class Appointment 
    {
        public int AppointmentId { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime Hour { get; set; }
        public string Severity { get; set; }
        public string Folio { get; set; }
    }
}
