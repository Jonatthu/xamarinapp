using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp.Services
{
    public class DoctorService
    {
        public Doctor GetDoctor()
        {
            return new Doctor()
            {
                Name = "Zheng",
                Address = "Los Arboles",
                Age = 50,
                CellphoneNumber = "6645746372",
                Hospital = "Del Prado",
                CURP = "sdfas3234234",
                UserType = "Doctor",
                AccountId = 2,
                Id = 2
            };
        }
    }
}
