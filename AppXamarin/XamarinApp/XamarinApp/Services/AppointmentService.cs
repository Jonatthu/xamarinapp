using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Models;

namespace XamarinApp.Services
{
    public class AppointmentService
    {
        public ICollection<Appointment> GetAllAppointments()
        {
            PatientService patient = new PatientService();
            List<Appointment> list = new List<Appointment>();
            list.Add(new Appointment
            {
                AppointmentId = 1,
                Patient = patient.GetPatient(),
                Status = "Libre",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 2,
                Patient = patient.GetPatient(),
                Status = "Cancelada",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 3,
                Patient = patient.GetPatient(),
                Status = "Libre",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 4,
                Patient = patient.GetPatient(),
                Status = "Libre",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 5,
                Patient = patient.GetPatient(),
                Status = "Cancelada",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 6,
                Patient = patient.GetPatient(),
                Status = "Pendiente",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 7,
                Patient = patient.GetPatient(),
                Status = "Pendiente",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 8,
                Patient = patient.GetPatient(),
                Status = "Pendiente",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 9,
                Patient = patient.GetPatient(),
                Status = "Pendiente",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 10,
                Patient = patient.GetPatient(),
                Status = "Pendiente",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            return list;
        }
    }
}
