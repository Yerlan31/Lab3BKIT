using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Rectangle : GeomFig
    {
        public int width, height;
        public Rectangle() { this.width = 1; this.height = 1; }
        public Rectangle(int width, int height)
        {
            if (width < 0) width *= (-1);
            if (height < 0) height *= (-1);
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get { return width; }
            set
            {
                if (value < 0) { width = (-1) * value; }
                else { width = value; }
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0) { height = (-1) * value; }
                else { height = value; }
            }
        }
        public override double EstSqr()
        {
            s = width * height;
            return s;
        }

        public override string ToString()
        {
            return "Площадь фигуры: " + EstSqr().ToString() + " Стороны: " + width.ToString() + ", " + height.ToString();
        }

    }

    class Square : Rectangle
    {
        public Square() : base(1, 1) { }
        public Square(int lenth) : base(lenth, lenth) { }

    }
}
