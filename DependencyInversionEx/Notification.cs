using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionEx
{
    internal class Notification
    {
        private INotification service;
        public Notification(INotification type)
        {
            service = type;
        }
        public void SendNotification()
        {
            service.SendNotification();
        }
    }
}
