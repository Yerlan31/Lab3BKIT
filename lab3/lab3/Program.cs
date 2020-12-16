using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;




namespace lab3
{
   

    abstract class GeomFig : IComparable<GeomFig>, IComparable
    {
        
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public int CompareTo(GeomFig a)
        {
            if (a.s < this.s) return 1;
            if (a.s > this.s) return -1;
            return 0;
        }

        public int CompareTo( object temp)

        {
            GeomFig o = temp as GeomFig;
            if (o != null)
                return this.s.CompareTo(o.s);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
        protected double s;

        public virtual double EstSqr()
        { return 1; }

    }

    

    
    class Program
    {
        static void Main(string[] args)
        {
            Square Example = new Square(20);
            Circle one = new Circle(10);
            Rectangle two = new Rectangle(30, 5);
            Square three = new Square(20);

            //ARRlist 


            //
            Console.WriteLine("\n ARRLIST \n");

            ArrayList figlist = new ArrayList() { Example, one, two, three };

            figlist.Sort();

            foreach (GeomFig temp in figlist)
            {
                Console.WriteLine(temp.ToString());
            }

            //
            Console.WriteLine("\n LIST \n");

            List<GeomFig> listof = new List<GeomFig>() { Example, one, two, three };

            listof.Sort();

            foreach (GeomFig temp in listof)
            {
                Console.WriteLine(temp.ToString());
            }
            //
            Console.WriteLine("\n Односвязный список \n");


            SimpleStack<GeomFig> SSS = new SimpleStack<GeomFig>(5);
            SSS.Push(Example);
            SSS.Push(one);
            SSS.Push(two);
            SSS.Push(three);
            SSS.Pop();
            Console.WriteLine("\n Односвязный список \n");
            SSS.PRINT();


            //Разреженная матрица
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nРазреженная матрица");
            Console.ResetColor();
            Matrix<GeomFig> matrix = new Matrix<GeomFig>(4, 4, 3, new FigureMatrixCheckEmpty());
            matrix[1, 1, 0] = one;
            matrix[1, 2, 1] = two;
            matrix[3, 3, 2] = three;
            Console.WriteLine(matrix.ToString());


        }
    }
}
