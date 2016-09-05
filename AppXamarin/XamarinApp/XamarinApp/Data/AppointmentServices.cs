using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp.Data
{
    public class AppointmentServices
    {
        public IEnumerable<Appointment> GetAllAppointments()
        {
            List<Appointment> AppointmentsList = new List<Appointment>();
            Appointment appointment = new Appointment
            {
                PatientName = "Anonimo Anonimo Anonimo",
                Folio = "0000",
                Subject = "Cita Médica",
                Time = new DateTime(2016, 07, 4),
                ImageUrl = "https://apple5x1.com/wp-content/uploads/2016/04/Steve-Jobs.jpg",
                Status = false

            };
            for (int i = 0; i < 10; i++)
            {
                appointment.Id = i + 1;
                AppointmentsList.Add(appointment);
            }

            return AppointmentsList;
        }

    }
}
