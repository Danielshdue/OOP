using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._09._2025
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of lines: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int space = n - i - 1; space > 0; space--)
                {
                    Console.Write(" ");
                }
                for (int lqvo = i; lqvo > 0; lqvo--)
                {
                    Console.Write("{0}",+lqvo);
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0}", +j);
                }
                Console.WriteLine();
            }
        }
    }
}
