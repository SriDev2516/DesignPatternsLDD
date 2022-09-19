using ObserverPattern.Obervables;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class MobileNotifyObserver : IObserver
    {
        public string phoneNumber;
        private readonly IObservable observable;

        public MobileNotifyObserver(string phoneNumber, IObservable observable )
        {
            this.observable = observable;
            this.phoneNumber = phoneNumber;
        }
        public void Update()
        {
            SendMessage(phoneNumber);
        }

        private void SendMessage(string phoneNumber)
        {
            Console.WriteLine($"Activated the mobile notification.Sent message to {phoneNumber} " +
                                $"The availble stock is {observable.GetStockData()}");
        }

       
    }
}
