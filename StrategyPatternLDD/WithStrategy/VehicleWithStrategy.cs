using StrategyPatternLDD.WithStrategy.DriveStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLDD.WithStrategy
{
    public class VehicleWithStrategy
    {
        IDriveStrategy driveObj;

        public VehicleWithStrategy(IDriveStrategy driveStrategy)
        {
            driveObj = driveStrategy;
        }

        public void Drive()
        {
            driveObj.Drive();
        }
    }
}
