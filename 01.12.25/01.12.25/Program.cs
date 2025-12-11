using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._12._25
{
    abstract class Figure
    {
        public abstract void Input();
        public abstract void Output();
        public abstract double FindArea();
        public abstract double FindPerimeter();
    }
    class Rectangle : Figure
    {
        private double lenght, width;
        public override void Input()
        {
            Console.WriteLine("Rectangle:");
            Console.Write("Lenght= ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width= ");
            width = double.Parse(Console.ReadLine());
        }
        public override double FindArea()
        {
            return lenght * width;
        }
        public override double FindPerimeter()
        {
            return 2 * (lenght + width);
        }
        public override void Output()
        {
            Console.WriteLine($"The rectangle with sides {lenght} and {width} has a perimeter of {this.FindPerimeter():f2} and an area of {this.FindArea():f2}.");
        }
    }
    class Rhombus : Figure
    {
        private double side,angle;
        public override void Input()
        {
            Console.WriteLine("Rhombus:");
            Console.Write("Side= ");
            side = double.Parse(Console.ReadLine());
            Console.Write("Angle= ");
            angle = double.Parse(Console.ReadLine());
        }
        public override double FindArea()
        {
            double area = side * side * Math.Sin(angle*Math.PI/180);
            return area;
        }
        public override double FindPerimeter()
        {
            return 4 * side;
        }
        public override void Output()
        {
            Console.WriteLine($"The rhombus with side {side} and angle {angle} degrees has a perimeter of {this.FindPerimeter():f2} and an area of {this.FindArea():f2}.");
        }
    }
    class Triangle : Figure
    {
        private double a, b, c;
        public override void Input()
        {
            Console.WriteLine("Triangle:");
            Console.Write("A= ");
            a = double.Parse(Console.ReadLine());
            Console.Write("B= ");
            b = double.Parse(Console.ReadLine());
            Console.Write("C= ");
            c = double.Parse(Console.ReadLine());
        }
        public override double FindArea()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
        public override double FindPerimeter()
        {
            return a + b + c;
        }
        public override void Output()
        {
            Console.WriteLine($"The triangle with sides {a}, {b} and {c} has a perimeter of {this.FindPerimeter():f2} and an area of {this.FindArea():f2}.");
        }
    }
    class Circle : Figure
    {
        private double radius;
        public override void Input()
        {
            Console.WriteLine("Circle:");
            Console.Write("Radius= ");
            radius = double.Parse(Console.ReadLine());
        }
        public override double FindArea()
        {
            return radius*radius*Math.PI;
        }
        public override double FindPerimeter()
        {
            return 2 * radius * Math.PI;
        }
        public override void Output()
        {
            Console.WriteLine($"The circle with a radius of {radius} has a perimeter of {this.FindPerimeter():f2} and an area of {this.FindArea():f2}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure a;
            Console.WriteLine("Press 1 for rectangle, 2 for rhombus, 3 for triangle or 4 for circle: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        a = new Rectangle();
                        a.Input();
                        a.Output();
                        break;
                    case 2:
                        a = new Rhombus();
                        a.Input();
                        a.Output();
                        break;
                    case 3:
                        a = new Triangle();
                        a.Input();
                        a.Output();
                        break;
                    case 4:
                        a = new Circle();
                        a.Input();
                        a.Output();
                        break;
                    default:
                        throw new Exception("Error");
                }
            }
            catch (Exception k)
            {
                Console.WriteLine(k.Message);
            }
        }
    }
}
