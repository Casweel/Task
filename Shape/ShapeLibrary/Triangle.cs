using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c) : base(a, b, c) { }

        public override double getArea()
        {
            if (a * a + b * b == c * c)
                return 0.5 * a * b;

            if (a * a + c * c == b * b)
                return 0.5 * a * c;

            if (c * c + b * b == a * a)
                return 0.5 * c * b;

            double p = 0.5 * (a + b + c);

            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
