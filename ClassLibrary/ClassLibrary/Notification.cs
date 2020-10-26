using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Notification
    {
        internal string Title { get; set; }
        protected internal string Description { get; set; }
        private protected DateTime Time { get; set; }
    }

    internal class Email: Notification
    {
        //Notification notification = new Notification();
        public Email()
        {
            Description = "Email body";
            Console.WriteLine(Description);
            Time = new DateTime();
            Console.WriteLine(Time);
        }
    }

    class Test
    {
        public Test()
        {
            //Title = "Bashliq";
            //Console.WriteLine(Title);
            Notification notification = new Notification();
            //notification.Title = "Bashliq";
            //Console.WriteLine(notification.Title);
            //notification.Description = "Hello World";
            //Console.WriteLine(notification.Description);
        }
    }
}
