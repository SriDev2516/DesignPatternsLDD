using FactoryPattern;
using System;

namespace FactoryPatternTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
               ShapeFactory shapeFactory = new ShapeFactory();
               IShape shape = shapeFactory.GetShape(ShapeTypes.Circle);
               shape.Draw();
            
        }
    }
}
