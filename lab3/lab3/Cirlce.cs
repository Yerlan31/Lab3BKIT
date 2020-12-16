using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Circle : GeomFig
    {
        double radius;
        public Circle() { radius = 1; }
        public Circle(double R) { radius = R; }
        public double Radius
        {
            get { return radius; }
            set { if (value < 0) value *= (-1); radius = value; }
        }

        public override double EstSqr()
        {
            s = 3.14 * radius * radius;
            return s;
        }
        public override string ToString()
        {
            return "Площадь круга = " + EstSqr().ToString() + " Радиус: " + radius.ToString();
        }

    }
}
