using StrategyPatternLDD.WithStrategy.DriveStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLDD.WithStrategy
{
    public class NormalVehicleS: VehicleWithStrategy
    {
        public NormalVehicleS(): base(new NormalDriveStrategy())
        {

        }
    }
}
