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
            
            List<Appointment> list = new List<Appointment>();
            for(int i=0;i<15;i++)
            {
                list.Add(CreateAppointment(i, "Pendiente"));
            }
            for (int i = 0; i < 25; i++)
            {
                list.Add(CreateAppointment(i, "Atendida"));
            }
            for (int i = 0; i < 8; i++)
            {
                list.Add(CreateAppointment(i, "Cancelada"));
            }


            return list;
        }
        private Appointment CreateAppointment(int id,string status)
        {
            PatientService patientService = new PatientService();
            DoctorService doctorService = new DoctorService();
            int day = id;
            return new Appointment
            {
                AppointmentId = id,
                Patient = patientService.GetPatientByUserId(2),
                Doctor = doctorService.GetDoctor(),
                Status = status,
                Type = "Cita Medica",
                AppointmentDate = new DateTime(2016,09,day+1,13,15,00),
                //AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            };
        }
        public ICollection<Appointment> GetAllAppointmentsByPatientId(int Id)
        {
            var patientsAppointments = GetAllAppointments().Where(x => x.Patient.Id == Id).ToList();
            return patientsAppointments;
        }
        public ICollection<Appointment> GetAllAppointmentsByPatientId(int Id,string status)
        {
            var appointments = GetAllAppointments()
                .Where(m => m.Status == status).ToList();
            return appointments;
        }


    }
}
