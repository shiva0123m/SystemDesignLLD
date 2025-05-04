using ObserverPattern_Behavourial_Design_.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_Behavourial_Design_.Observer
{
    public class EmailNotificationAlert:NotificationAlert
    {
        Stock observer;
        String mail;
        public EmailNotificationAlert(string mail, Stock observer)
        {
            this.observer = observer;
            this.mail = mail;
        }
        public void update()
        {
            sendemail(mail);
        }

        public void sendemail(String email)
        {
            Console.WriteLine("Email sent to " + email);
        }
    }
}
