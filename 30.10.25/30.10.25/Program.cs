using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._10._25
{
    class Rectangle
    {
        private int height, length;
        public Rectangle(int a, int b)
        {
            height = a;
            length = b;
        }
        public Rectangle()
        {
            height = 0;
            length = 0;
        }
        public int Height
        {
            set { height = value; }
        }
        public int Length
        {
            set { length = value; }
        }
        public int Area
        {
            get { return height * length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle pravougulnik1 = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Rectangle pravougulnik2 = new Rectangle(13,7);
            Rectangle pravougulnik3 = new Rectangle();
            Rectangle[] masiv = new Rectangle[3];
            masiv[0] = pravougulnik1;
            masiv[1] = pravougulnik2;
            masiv[2] = pravougulnik3;
            Console.WriteLine("Pravougulnik3:");
            Console.Write("Height: ");
            pravougulnik3.Height = int.Parse(Console.ReadLine());
            Console.Write("Length: ");
            pravougulnik3.Length = int.Parse(Console.ReadLine());
            Console.WriteLine("pravougulnik1's area is: " + pravougulnik1.Area);
            Console.WriteLine("pravougulnik2's area is: " + pravougulnik2.Area);
            Console.WriteLine("pravougulnik3's area is: " + pravougulnik3.Area);
            int max =0;
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i].Area > max) max = masiv[i].Area;
            }
            Console.WriteLine("The largest area is " + max);

            
        }
    }
}
