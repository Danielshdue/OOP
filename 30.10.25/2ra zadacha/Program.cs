using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ra_zadacha
{
    class Car
    {
        private string brand, colour;
        private int regnumber;
        public Car(string brand, string colour, int number)
        {
            this.brand = brand;
            this.colour = colour;
            this.regnumber = number;
        }
        public Car()
        {
        }
        public string Brand
        {
            get { return this.brand; }
            set { brand = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public int RegNumber
        {
            get { return regnumber; }
            set { regnumber = value; }
        }
        public void Info()
        {
            Console.WriteLine("The brand of the car is: "+this.Brand);
            Console.WriteLine("The colour of the car is: " + this.Colour);
            Console.WriteLine("The registration number of the car is: " + this.RegNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car proba = new Car("Golf", "blue", 1523);
            Car kola = new Car();
            kola.Brand = Console.ReadLine();
            kola.Colour = Console.ReadLine();
            kola.RegNumber = int.Parse(Console.ReadLine());
            proba.Info();
            kola.Info();
        }
    }
}
