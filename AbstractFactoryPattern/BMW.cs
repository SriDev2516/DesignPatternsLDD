using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class BMW : IVehicle
    {
        public void GetAverage()
        {
            Console.WriteLine("BWM Average");
        }
    }
}
