using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Services
{
    public interface ILocalNotifications
    {
        void SendLocalNotification(string title, string description, int iconId);
    }
}
