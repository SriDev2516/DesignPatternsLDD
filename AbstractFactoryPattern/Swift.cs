using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Swift : IVehicle
    {
        public void GetAverage()
        {
            Console.WriteLine("Swift Average");
        }
    }
}
