using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLDD.WithStrategy.DriveStrategy
{
    class NormalDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Normal Drive Capability!");
        }
    }
}
