using DecoratorPatternLib;
using System;

namespace DecoratorPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePizza basePizza = new MushroomPizza(new VegDelight());

            Console.WriteLine(basePizza.Cost());
        }
    }
}
