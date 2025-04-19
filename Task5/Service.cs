using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTask1.InnerClass
{
    public class EmailService
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }
    public class Notification
    {
        private EmailService emailService = new EmailService();
        public void Alert(string message)
        {
            emailService.Send(message);
        }
    }
    // Aystex xaxtvace "Dependecy Inversion" skzbunqy. "High-Level moduls should not depend Low_Level Moduls". Tvyal depqum High-Level moduly Notification classn e, 
    //vory parunakum e cragri himnakan gaxapary ev irakanacnum e himnakan funkcionaly. Aysinqn ete EmailService classum popoxuttyunner anenq cragri ashxatanqy karox e
    //xapanvel, ev hark klini poxel naev Notification-y.

    public interface IService
    {
        void Send(string message);
    }

    public class Email_Service : IService 
    {
        public void Send(string message) {
            Console.WriteLine("Sending Email: " + message);
        }
    }
    public class NotificatioN 
    {
        private IService service;
        public NotificatioN(IService service)
        {
            this.service = service;
        }

        public void ALert(string message) {
            service.Send(message);
        }

        //Notification-y arden kaxvac e Interface-ic ayl voch te konkret classic(Email_service)
    }

}

