using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public enum ShapeTypes
    {
        Circle = 1,
        Square = 2,
        Rectangle = 3
    }
    public class ShapeFactory
    {
        public IShape GetShape(ShapeTypes type)
        {
            switch (type)
            {
                case ShapeTypes.Circle:
                    return new Circle();
                case ShapeTypes.Square:
                    return new Square();
                default:
                    return new Rectangle();
            }
        }
    }
}
