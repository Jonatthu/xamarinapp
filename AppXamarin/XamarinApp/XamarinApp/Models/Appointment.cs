using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public DateTime Time { get; set; }
        public string Folio { get; set; }
        public string Subject { get; set; }
        public bool Status { get; set; }
        public string ImageUrl { get; set; }
    }
}
