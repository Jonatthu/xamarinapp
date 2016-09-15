using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Models
{
    public class Notification
    {
        [PrimaryKey]
        public int Id { get; set; }
        public bool Active { get; set; }
    }
}
