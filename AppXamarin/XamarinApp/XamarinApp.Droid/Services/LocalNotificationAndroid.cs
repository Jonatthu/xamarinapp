using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinApp.Services;
using XamarinApp.Droid.Services;

[assembly: Xamarin.Forms.Dependency(typeof(LocalNotificationAndroid))]
namespace XamarinApp.Droid.Services
{
    public class LocalNotificationAndroid : ILocalNotifications
    {
        public LocalNotificationAndroid()
        {

        }

        #region ILocalNotifications implementation

        public void SendLocalNotification(string title, string description, int iconID)
        {
            // Instantiate the builder and set notification elements:
            Notification.Builder builder = new Notification.Builder(Application.Context)
                .SetContentTitle(title)
                .SetContentText(description)
                .SetSmallIcon(Resource.Drawable.icon);

            // Build the notification:
            Notification notification = builder.Build();

            // Get the notification manager:
            NotificationManager notificationManager =
                Application.Context.GetSystemService(Context.NotificationService) as NotificationManager;

            // Publish the notification:
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);
        }

        #endregion
    }
}