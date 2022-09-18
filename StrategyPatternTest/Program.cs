using StrategyPatternLDD.WithoutStrategy;
using StrategyPatternLDD.WithStrategy;
using System;

namespace StrategyPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleWithStrategy vehicle = new SportsVehicleS();
            vehicle.Drive();
        }
    }
}
