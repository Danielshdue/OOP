using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Point
    {
        private double x, y;
        public string name;
        public void Input()
        {
            Console.Write("x= ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            y = double.Parse(Console.ReadLine());
        }
        public static void Input(Point a)
        {
            Console.WriteLine(a.name + " coordinates:");
            Console.Write("x= ");
            string tempx = Console.ReadLine();
            a.x = int.Parse(tempx);
            Console.Write("y= ");
            string tempy = Console.ReadLine();
            a.y = int.Parse(tempy);
        }
        public static void Output(Point a)
        {
            Console.WriteLine("The coordinates of "+a.name+" are: x= {0}, y= {1}", +a.x, a.y);
        }
        public static void Distance(Point a, Point b)
        {
            double dx = Math.Abs(a.x - b.x);
            double dy = Math.Abs(a.y - b.y);
            double razst = Math.Sqrt(dx * dx + dy * dy);
            Console.WriteLine($"The distance between {a.name} and {b.name} is {razst:f2}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point tochka1 = new Point();
            tochka1.name = "tochka1";
            Point tochka2 = new Point();
            tochka2.name = "tochka2";
            Point tochka3 = new Point();
            tochka3.name = "tochka3";
            Point.Input(tochka1);
            Point.Input(tochka2);
            Point.Input(tochka3);
            Point.Distance(tochka1, tochka2);
        }
    }
}
