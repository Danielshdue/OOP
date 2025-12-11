using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ra_zadacha
{
    abstract class Vehicle
    {
        protected int enginevolume, maxspeed;
        public Vehicle()
        { }
        public abstract void Info();
    }
    class Car : Vehicle
    {
        private int mesta;
        public Car() : base()
        {
            enginevolume = int.Parse(Console.ReadLine());
            maxspeed = int.Parse(Console.ReadLine());
            mesta = int.Parse(Console.ReadLine());
        }
        public override void Info()
        {
            Console.WriteLine($"Engine volume={enginevolume}");
            Console.WriteLine($"Maxspeed ={maxspeed}");
            Console.WriteLine($"Mesta={mesta}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle a = new Car();
            a.Info();
        }
    }
}
