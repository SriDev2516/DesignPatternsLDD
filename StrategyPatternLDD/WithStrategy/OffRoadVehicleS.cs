using StrategyPatternLDD.WithStrategy.DriveStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLDD.WithStrategy
{
    public class OffRoadVehicleS: VehicleWithStrategy
    {
        public OffRoadVehicleS(): base(new SportsDriveStrategy())
        {

        }
    }
}
