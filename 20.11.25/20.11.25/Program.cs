using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._25
{
    class Pet
    {
        protected int age;
        protected string name;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Getsound()
        {
            Console.WriteLine("*animal sound*");
        }
        public virtual void Info()
        {
            Console.WriteLine($"My pet's name is {name}\nIts age is {age}");
        }
    }
    class Cat : Pet
    {
        public Cat(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public override void Getsound()
        {
            Console.WriteLine("Meow meow");
        }
        public override void Info()
        {
            Console.WriteLine($"My cat's name is {name}\nIts age is {age}");
        }
    }
    class Dog : Pet
    {
        public Dog(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public override void Getsound()
        {
            Console.WriteLine("Woof Woof");
        }
        public override void Info()
        {
            Console.WriteLine($"My dog's name is {name}\nIts age is {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pet[] pets = { new Cat("Pisana",4), new Cat("Tom",3), new Dog("Sharo",1), new Dog("Johnny",5), new Dog("Bogi",2) };
            foreach (Pet k in pets)
            {
                k.Getsound();
                k.Info();
            }
        }
    }
}
