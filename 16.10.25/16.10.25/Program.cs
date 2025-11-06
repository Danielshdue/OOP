using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._25
{
    class Rectangle
    {
        private int height, width;
        public void Input()
        {
            Console.WriteLine("Rectangle:");
            Console.Write("Height= ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Width= ");
            width = int.Parse(Console.ReadLine());
        }
        public int Area()
        {
            return height * width;
        }
        public static int Parameter(Rectangle a)
        {
            return 2 * (a.width + a.height);
        }
        public void Output()
        {
            Console.WriteLine("Height and width of rectangle= {0}, {1}", +height, width);
            Console.WriteLine("The area of the rectangle is {0}", +this.Area());
            Console.WriteLine("The parameter of the rectangle is {0}", +Rectangle.Parameter(this));
        }
    }
    class Triangle
    {
        private double a, b, c;
        public void Input()
        {
            Console.WriteLine("Triangle:");
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("a= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            c = int.Parse(Console.ReadLine());
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static double Perimeter(Triangle tri)
        {
            return tri.a + tri.b + tri.c;
        }
        public void Output()
        {
            Console.WriteLine("The sides of the triangle are: {0}, {1}, {2}", +a, b, c);
            Console.WriteLine("Area of triangle= {0}", +Area());
            Console.WriteLine("Perimeter of triangle= {0}",+Triangle.Perimeter(this));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Input();
            rect1.Output();
            Triangle tri = new Triangle();
            tri.Input();
            tri.Output();
        }
    }
}
