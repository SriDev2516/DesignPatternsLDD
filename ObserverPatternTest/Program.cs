using ObserverPattern.Obervables;
using ObserverPattern.Observer;
using System;

namespace ObserverPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IObservable observable = new IphoneObservable();
            IObserver observer1 = new MobileNotifyObserver("9989933844", observable);
            IObserver observer2 = new EmailNotifyObserver(observable, "srinivas@gmail.com");

            observable.Add(observer1);
            observable.Add(observer2);

            observable.SetStockData(10);
        }
    }
}
