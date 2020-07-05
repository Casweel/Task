using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Shape
    {
        protected double r, a, b, c;
        protected const double pi = 3.14;
        public Shape(double r)
        {
            this.r = r;
            this.a = this.b = this.c = 0;
        }

        public Shape(double a, double b, double c)
        {
            this.r = 0;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public virtual double getArea()
        {
            if (r == 0)
                return new Triangle(a, b, c).getArea();
            else
                return new Circle(r).getArea();
        }
    }
}
