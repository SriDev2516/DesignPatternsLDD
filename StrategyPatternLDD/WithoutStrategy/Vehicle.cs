using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLDD.WithoutStrategy
{
    public class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Normal vehicle capability!");
        }
    }
}
