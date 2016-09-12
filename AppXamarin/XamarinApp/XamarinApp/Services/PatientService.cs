using System.Collections.Generic;
using XamarinApp.Models;
using System.Linq;
namespace XamarinApp.Services
{

    internal  class PatientService
    {
        
        private Patient CreatePatient(int id)
        {
            return new Patient
            {
                Name = "Jose Manuel Alvarez Cervantes",
                Address = "Santa Fe",
                Religion = "Cristiano",
                Age = 21,
                CURP = "AACM950823HBRLN01",
                BloodType = "O +",
                CellphoneNumber = "6643864060",
                Disability = "Ciego",
                EthnicGroup = "Cristiano",
                SocioEconomicLevel = "Medio",
                EmergencyNumber = "6642332760",
                UserType = "Paciente",
                AccountId = id,
                Id = id

            };

        }
        public Patient GetPatientByUserId(int userId)
        {
            Patient patient = GetListOfPatients().Where(x => x.Id == userId).FirstOrDefault();
            return patient;
        }
        public string GetPatientNameByUserId(int userId)
        {
            Patient patient = GetPatientByUserId(userId);
            string name = "";
            if( patient!= null){
                return name = patient.Name;
            } 
            else
            {
                return name;
            }
                
        }   
        public ICollection<Patient> GetListOfPatients()
        {
            List<Patient> list = new List<Patient>();
                
            for(int i=0;i<10;i++)
            {
                list.Add(CreatePatient(i + 1));
            }
            return list;
        }
    }
    
}