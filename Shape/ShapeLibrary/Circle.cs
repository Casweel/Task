using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle: Shape
    {
        public Circle(double r):base(r)
        {
        }

        public override double getArea()
        {
            return pi*r*r;
        }
    }

}
