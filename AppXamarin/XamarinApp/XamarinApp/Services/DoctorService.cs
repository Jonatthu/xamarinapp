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
        public Doctor GetDoctor(int Id)
        {
            return new Doctor()
            {
                Id = 1,
                Name = "zheng",
                Email = "zheng@me.com",
                Username = "zheng",
                Password = "123"
            };
        }
    }
}
