using AbstractFactoryPattern;
using System;

namespace AbstractTestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetVehicleFactory getVehicleFactory = new GetVehicleFactory();
            IVehicleFactory vehicle =  getVehicleFactory.GetVehicleFromFactory("Luxury");
            IVehicle vehicle1 =  vehicle.GetVehicle("BMW");
            vehicle1.GetAverage();

        }
    }
}
