using StrategyPatternLDD.WithStrategy.DriveStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLDD.WithStrategy
{
    public class SportsVehicleS: VehicleWithStrategy
    {
        public SportsVehicleS(): base(new SportsDriveStrategy())
        {

        }
    }
}
