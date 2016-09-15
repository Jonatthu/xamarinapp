using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;
using XamarinApp.Models.Helpers;
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

            Account account = GetAccounts().Where(x => x.Username == userName && x.Password == password).FirstOrDefault();
            if (account != null)
            {
                return true;
            }
            else
                return false;
           
        }
        public string GetUserNameType(string UserName)
        {
            
            var item1 = new UserNameType
            {
                UserName = "Xamarino",
                UserType = "Paciente"
            };
            var item2 = new UserNameType
            {
                UserName = "XamaDoc",
                UserType = "Doctor"
            };
            var UserNameTypeTable = new List<UserNameType> {item1,item2 };

            foreach(var item in UserNameTypeTable)
            {
                if( item.UserName==UserName)
                {
                    return item.UserType;
                }
            }
            return null;
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
