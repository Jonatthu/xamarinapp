using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;
using XamarinApp.ViewModels;

namespace XamarinApp.Services
{
    public class AccountsService
    {

        
        public AccountsService()
        {


        }
       

        public Patient GetPatientByUserId(int Id)
        {
            Patient patient = new PatientService().GetPatientByUserId(Id);

            return patient;
        }
        public Doctor GetDoctorByUserId(int Id)
        {
            Doctor doctor = new DoctorService().GetDoctor();

            return doctor;
        }
        public bool Authentication(string userName,string password)
        {
            int id = GetAccounts().Where(x => x.Username == userName).FirstOrDefault().Id;
            if (id != 0)
            {
                return true;
            }
            else
                return false;
        }
        
        private ICollection<Account> GetAccounts()
        {
            var patientsAccount = new Account
            {
                Id = 1,
                Email = "xamarin@gmail.com",
                Username = "Xamarino",
                Password = "123"
            };
            var DoctorsAccount = new Account
            {
                Id = 2,
                Email = "XamarinDoc@medexp.com",
                Username = "XamaDoc",
                Password = "456"
            };

            var accounts = new List<Account>
            {
                patientsAccount,DoctorsAccount
            };

            return accounts;
        }
        
    }
}
