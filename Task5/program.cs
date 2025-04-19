using SolidTask1.InnerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTask1
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //Task4 - um amen inch kargina


            var email = new Email_Service();
            email.Send("Sending email");
            var notification = new NotificatioN(email);
            notification.ALert("Alerting");


            Console.Read();
        }
    }
}

