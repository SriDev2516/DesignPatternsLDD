using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLDD.WithStrategy.DriveStrategy
{
    class SportsDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Sports Drive Capability");
        }
    }
}
