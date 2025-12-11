using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._12._2025
{
    interface IFigure
    {
        void Input();
        void Output();
        void FindArea();
    }
    class Square:IFigure
    {
        private int side;
        public void Input()
        {
            Console.Write("Square side= ");
            side = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"The square has a side of {side}");
        }
        public void FindArea()
        {
            Console.WriteLine($"The square has an area of {side * side}");
        }
    }
    class Circle : IFigure
    {
        private int radius;
        public void Input()
        {
            Console.Write("Circle radius= ");
            radius = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"The circle has a radius of {radius}");
        }
        public void FindArea()
        {
            Console.WriteLine($"The circle has an area of {(radius * radius * Math.PI):f2}");
        }
    }
    class Triangle : IFigure
    {
        private int a,b,c;
        public void Input()
        {
            Console.Write("Triangle A= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Triangle B= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Triangle C= ");
            c = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"The triangle has sides {a}, {b} and {c}");
        }
        public void FindArea()
        {
            double p = (a + b + c) / 2;
            Console.WriteLine($"The triangle has an area of {Math.Sqrt(p * (p - a) * (p - b) * (p - c)):f2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFigure[] masiv = { new Square(), new Triangle(), new Circle() };
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i].Input();
                masiv[i].Output();
                masiv[i].FindArea();
            }
           
        }
    }
}
