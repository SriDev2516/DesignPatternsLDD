using DecoratorPatternLib.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternLib
{
    public class ExtraCheese : IPizzaDecorator
    {
        BasePizza basePizza;
        public ExtraCheese(BasePizza basePizza)
        {
            this.basePizza = basePizza;
        }
        public override int Cost()
        {
            return this.basePizza.Cost() + 10;
        }
    }
}
