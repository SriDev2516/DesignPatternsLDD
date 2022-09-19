using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Obervables
{
    public interface IObservable
    {
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();
        public void SetStockData(int newStockAdded);
        public int GetStockData();
    }
}
