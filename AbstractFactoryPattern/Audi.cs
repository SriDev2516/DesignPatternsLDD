using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Audi : IVehicle
    {
        public void GetAverage()
        {
            Console.WriteLine("BWM Average");
        }
    }
}
