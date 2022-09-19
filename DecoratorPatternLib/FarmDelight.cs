using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternLib
{
    public class FarmDelight : BasePizza
    {
        public override int Cost()
        {
            return 5;
        }
    }
}
