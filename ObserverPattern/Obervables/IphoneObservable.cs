using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Obervables
{
    public class IphoneObservable : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        public int StockData;

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }
        public int GetStockData()
        {
            return StockData;
        }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void SetStockData(int newStockData)
        {
            if(StockData == 0)
            {
                Notify(); 
            }
            StockData += newStockData;
        }
    }
}
