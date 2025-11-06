using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._09._2025
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1= square\n2= rectangle\n3= circle\n4= triangle\n5= parallelogram\n6= trapezoid");
            Console.Write("Chose a figure: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Side length= ");
                    int sqLength = int.Parse(Console.ReadLine());
                    int sqLice = sqLength * sqLength;
                    Console.WriteLine("The area of the square is {0}", + sqLice);
                    break;
                case 2:
                    Console.Write("Length= ");
                    int rLength = int.Parse(Console.ReadLine());
                    Console.Write("Width= ");
                    int rWidth = int.Parse(Console.ReadLine());
                    int rLice = rLength * rWidth;
                    Console.WriteLine("The area of the rectangle is {0}", +rLice);
                    break;
                case 3:
                    Console.Write("Radius= ");
                    double radius = double.Parse(Console.ReadLine());
                    double cLice = radius * radius * Math.PI;
                    Console.WriteLine("The area of the circle is {0:f2}", +cLice);
                    break;
                case 4:
                    Console.Write("a= ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("c= ");
                    double c = double.Parse(Console.ReadLine());
                    double half = (a + b + c) / 2;
                    double tLice = Math.Sqrt(half * (half - a) * (half - b) * (half - c));
                    Console.WriteLine("The area of the triangle is {0:f2}", +tLice);
                    break;
                case 5:
                    Console.Write("Side1= ");
                    double side1 = double.Parse(Console.ReadLine());
                    Console.Write("Side2= ");
                    double side2 = double.Parse(Console.ReadLine());
                    Console.Write("Angle= ");
                    double angle = double.Parse(Console.ReadLine());
                    angle = angle * Math.PI / 180;
                    double pLice = (side1 * side2 * Math.Sin(angle));
                    Console.WriteLine("The area of the parallelogram is {0}", +pLice);
                    break;
                case 6:
                    Console.Write("Big Base= ");
                    double bBase = double.Parse(Console.ReadLine());
                    Console.Write("Small Base= ");
                    double sBase = double.Parse(Console.ReadLine());
                    Console.Write("Heigth= ");
                    double heigth = double.Parse(Console.ReadLine());
                    double trapLice = ((bBase+sBase)*heigth)/2;
                    Console.WriteLine("The area of the trapezoid is {0}", +trapLice);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
}
