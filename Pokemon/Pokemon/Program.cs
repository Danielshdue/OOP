using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Trainer
    {
        private string name;
        public int badges;
        private int numberofpokemon;
        List<Pokemon> collection = new List<Pokemon>();
        public void Input()
        {
            Console.Write("Name of trainer: ");
            name = Console.ReadLine();
            badges = 0;
            Console.Write("Number of Pokemon: ");
            numberofpokemon = int.Parse(Console.ReadLine());
            this.Collection();
        }
        public  void Collection()
        {
            for (int i = 0; i < numberofpokemon; i++)
            {
                Console.WriteLine("Pokemon "+(i+1));
                Pokemon b = new Pokemon(Console.ReadLine(), Console.ReadLine(),int.Parse(Console.ReadLine()));
                collection.Add(b);
            }
        }
        public void TrainerStats()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Number of badges: {badges}");
            Console.WriteLine("Pokemon collection:");
            for (int i = 0; i < numberofpokemon; i++)
            {
                collection[i].PokeStats();
            }
        }
    }
    class Pokemon
    {
        private string name, element;
        public int hp;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Element
        {
            get { return element; }
            set { element = value; }
        }
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public Pokemon() { }
        public Pokemon(string a, string b, int c)
        {     
            name = a;
            element = b;
            hp = c;
        }
        public void PokeStats()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Element: {this.Element}");
            Console.WriteLine($"HP: {this.HP}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trainer a = new Trainer();
            a.Input();
            Trainer b = new Trainer();
            b.Input();
            Trainer[] grupaturnir = new Trainer[] { a, b };
            int br = 0;
            string komanda = Console.ReadLine();
            while (komanda != "End")
            {
                if (komanda == "Tournament")
                {
                    komanda = Console.ReadLine();
                    if (komanda == "Fire") br = 1;
                    if (komanda == "Water") br = 2;
                    if (komanda == "Electricity") br = 3;
                    switch (br)
                    {
                        case 1:
                            for (int i = 0; i < grupaturnir.Length; i++)
                            {
                                
                            }
                            break;

                    }
                }
            }
        }
    }
}
