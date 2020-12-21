using System;
using System.Collections.Generic;
using System.Text;

namespace helloWorld
{
    class Notification:Interface
    {
        private string sender;
        private string message;
        private string date;

        //Default constructor
        public Notification()
        {
            sender = "Admin";
            message = "default notification";
            date = " ";
        }
        //Constructor
        public Notification (string sender, string message, string date)
        {
            this.sender = sender;
            this.message = message;
            this.date = date;
        }

        //here is defined the methods that lies in the interface, and the access modifier
        public void ShowNotification()
        {
            Console.WriteLine("WhatsApp: '{0}' sent by {1}. {2}",message, sender, date);
        }
        public string GetDate()
        {
            return date;
        }
    }
}
