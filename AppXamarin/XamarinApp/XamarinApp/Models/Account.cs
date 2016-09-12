using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public int Age { get; set; }
        public string CellphoneNumber { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }
}
