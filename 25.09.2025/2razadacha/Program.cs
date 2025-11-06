using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2razadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inputs:");
            int sum = 0;
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
                sum += n;
            } while (n != 0);
            Console.WriteLine(sum);
        }
    }
}
