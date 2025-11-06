using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ra_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a: ");
                int a = int.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    //throw new Exception("Nevalidna stojnost!");
                    Exception Nevaliden = new Exception("Nevalidna stojnost!");
                    throw Nevaliden;
                }
                double b = Math.Sqrt(a);
                Console.WriteLine($"{b:f3}");
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
            finally
            {
                Console.WriteLine("End of program.");
            }
        }
    }
}
