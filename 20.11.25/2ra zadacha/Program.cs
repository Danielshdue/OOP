using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ra_zadacha
{
    class Dot2D
    {
        protected int x, y;
        public Dot2D()
        {
            x = 0;
            y = 0;
        }
        public Dot2D(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void Info()
        {
            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine($"The dot's coordinates are:\nx={x}\ny={y}");
            Console.WriteLine($"The dot's distance from point O is {distance}");
        }
    }
    class Dot3D : Dot2D
    {
        private int z;
        public Dot3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Dot3D(int x, int y, int z) : base(x, y)
        {
            //this.x = x;
            //this.y = y;
            this.z = z;
        }
        public override void Info()
        {
            double distance = Math.Sqrt(x * x + y * y + z * z);
            Console.WriteLine($"The dot's coordinates are:\nx={x}\ny={y}\nz={z}");
            Console.WriteLine($"The dot's distance from point O is {distance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dot2D tochka;
            Console.WriteLine("Press 2 for two-dimensional point.\nPress 3 for three-dimensional point.\nTo end the program type 'end'");
            bool isit2or3 = false;
            while (isit2or3==false)
            {
                try
                {
                    string  n = Console.ReadLine().ToLower();
                    if (n != "2" && n != "3" && n!= "end")
                    {
                        throw new Exception("Invalid input. Choose between 2 and 3!");
                    }
                    switch (n)
                    {
                        case "2":
                            Console.WriteLine("Enter x and y coordinates:");
                            tochka = new Dot2D(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                            tochka.Info();
                            isit2or3 = true;
                            break;
                        case "3":
                            Console.WriteLine("Enter x, y and z coordinates:");
                            tochka = new Dot3D(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                            tochka.Info();
                            isit2or3 = true;
                            break;
                        case "end":
                            isit2or3 = true;
                            break;
                    }
                }
                catch (Exception k)
                {
                    Console.WriteLine(k.Message);
                    Console.WriteLine("Enter a number.");
                }
            }
        }
    }
}
