using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._11._25
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b:");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine($"c={c}");
            }
            catch (FormatException k)
            {
                Console.WriteLine(k.Message);
            }
            catch (OverflowException k)
            {
                Console.WriteLine(k.Message);
            }
            catch (DivideByZeroException k)
            {
                Console.WriteLine("Na 0 ne se deli!");
            }
            finally { Console.WriteLine("Goodbye"); }
        }
    }
}
