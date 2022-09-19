using DecoratorPatternLib.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternLib
{
    public class MushroomPizza : IPizzaDecorator
    {
        BasePizza basePizza;
        public MushroomPizza(BasePizza basePizza)
        {
            this.basePizza = basePizza;
        }
        public override int Cost()
        {
            return this.basePizza.Cost() + 20;
        }
    }
}
