using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionEx
{
    internal class Email : INotification
    {
        public string from_email { get; set; }
        public string to_email { get; set; }
         
        public void SendNotification()
        {
            // sending email code 
        }
    }
}
