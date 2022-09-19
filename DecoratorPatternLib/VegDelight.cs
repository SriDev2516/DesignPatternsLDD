using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternLib
{
    public class VegDelight : BasePizza
    {
        public override int Cost()
        {
            return 4;
        }
    }
}
