using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLDD.WithoutStrategy
{
    public class SportsVehicle: Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Sports drive capability");
        }
    }
}
