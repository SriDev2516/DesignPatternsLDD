using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLDD.WithoutStrategy
{
    public class OfRoadVehicle: Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Sports Vehicle Capability");
        }
    }
}
