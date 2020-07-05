using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape a = new Shape(1);
            Shape b = new Circle(2);
            Shape c = new Shape(3, 4, 5);
            Shape d = new Triangle(6, 4, 5);
        }
    }
}
