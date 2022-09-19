using ObserverPattern.Obervables;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class EmailNotifyObserver : IObserver
    {
        private string emailid;
        private readonly IObservable observable;

        public EmailNotifyObserver(IObservable observable, string emailid)
        {
            this.observable = observable;
            this.emailid = emailid;
        }
        public void Update()
        {
            SendEmail(emailid);
        }

        private void SendEmail(string emailid)
        {
            Console.WriteLine($"Email sent to {emailid}");
        }
    }
}
