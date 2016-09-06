using System.Collections.Generic;
using XamarinApp.Models;

namespace XamarinApp.Services
{
   
        internal  class PatientService
        {
            public Patient GetPatient()
            {
                return new Patient
                {
                    Name = "Anonimo Anonimo Anonimo",
                    Photo = "patientImage.png",
                    Address = "Santa Fe",
                    Religion = "Cristiano",
                    Service = "Servicio",
                    Age = 21,
                    CURP = "AACM950823HBRLN01",
                    BloodType = "O +",
                    CellphoneNumber = "6643864060",
                    Email = "paciente@me.com",
                    EmergencyNumber = "6642332760",
                    Hospital = "ISSSTECALI",
                    Username = "pepePaciente",
                    Password = "123"
                };
            }

            public ICollection<Patient> GetListOfPatients()
            {
                List<Patient> list = new List<Patient>();
                list.Add(new Patient
                {
                    Name = "Anonimo Anonimo Anonimo",
                    Photo = "patientImage.png",
                    Address = "Santa Fe",
                    Religion = "Cristiano",
                    Service = "Servicio",
                    Age = 21,
                    CURP = "AACM950823HBRLN01",
                    BloodType = "O +",
                    CellphoneNumber = "6643864060",
                    Email = "paciente@me.com",
                    EmergencyNumber = "6642332760",
                    Hospital = "ISSSTECALI",
                    Username = "pepePaciente",
                    Password = "123"
                });
                list.Add(new Patient
                {
                    Name = "Anonimo Anonimo Anonimo",
                    Photo = "patientImage.png",
                    Address = "Santa Fe",
                    Religion = "Cristiano",
                    Service = "Servicio",
                    Age = 21,
                    CURP = "AACM950823HBRLN01",
                    BloodType = "O +",
                    CellphoneNumber = "6643864060",
                    Email = "paciente@me.com",
                    EmergencyNumber = "6642332760",
                    Hospital = "ISSSTECALI",
                    Username = "pepePaciente",
                    Password = "123"
                });
                list.Add(new Patient
                {
                    Name = "Anonimo Anonimo Anonimo",
                    Photo = "patientImage.png",
                    Address = "Santa Fe",
                    Religion = "Cristiano",
                    Service = "Servicio",
                    Age = 21,
                    CURP = "AACM950823HBRLN01",
                    BloodType = "O +",
                    CellphoneNumber = "6643864060",
                    Email = "paciente@me.com",
                    EmergencyNumber = "6642332760",
                    Hospital = "ISSSTECALI",
                    Username = "pepePaciente",
                    Password = "123"
                });
                list.Add(new Patient
                {
                    Name = "Anonimo Anonimo Anonimo",
                    Photo = "patientImage.png",
                    Address = "Santa Fe",
                    Religion = "Cristiano",
                    Service = "Servicio",
                    Age = 21,
                    CURP = "AACM950823HBRLN01",
                    BloodType = "O +",
                    CellphoneNumber = "6643864060",
                    Email = "paciente@me.com",
                    EmergencyNumber = "6642332760",
                    Hospital = "ISSSTECALI",
                    Username = "pepePaciente",
                    Password = "123"
                });
                return list;
            }
        }
    
}