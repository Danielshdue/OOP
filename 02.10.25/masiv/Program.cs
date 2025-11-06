using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of elements: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 10 || n > 50)
            {
                Console.WriteLine("Invalid size.");
                return;
            }
            int[] input = new int[n];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            int sbor = 0;
            foreach (int k in input)
            {
                sbor += k;
            }
            Console.WriteLine("Srednoaritmetichnoto e {0}",+(sbor/n));
            for (int i = 0; i < n; i += 2)
            {
                input[i] *= 15;
            }
            foreach (int k in input)
            {
                Console.Write(k+" "); 
            }
        }
    }
}
