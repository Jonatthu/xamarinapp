using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.ViewModels;

namespace XamarinApp.Services
{
    public class UserService
    {

        public User GetUser(int Id)
        {
            return new User()
            {
                Id = 1,
                Name = "Xamarino",
                Email = "xamarin@gmail.com",
                Username = "Xamarino",
                Password = "123"
            };
        }
    }
}
