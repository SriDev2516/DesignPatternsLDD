using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternLib
{
    public class Margarita : BasePizza
    {
        public override int Cost()
        {
            return 2;
        }
    }
}
