using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ra_zadacha
{
    interface IPredator
    {
        void Walk();
        void Run();
        void Rest();
        void Sound();
    }
    class Tiger : IPredator
    {
        void IPredator.Walk()
        {
            Console.WriteLine("The tiger walks silently in the jungle.");
        }
        void IPredator.Run()
        {
            Console.WriteLine("The tiger runs swiftly through the bushes to catch its prey.");
        }
        void IPredator.Rest()
        {
            Console.WriteLine("The tiger rests 10 hours a day.");
        }
        void IPredator.Sound()
        {
            Console.WriteLine("The tiger roars like a thunder.");
        }
    }
    class Lion : IPredator
    {
        void IPredator.Walk()
        {
            Console.WriteLine("The lion sneaks through the tall grass.");
        }
        void IPredator.Run()
        {
            Console.WriteLine("The lion races to catch an antilope.");
        }
        void IPredator.Rest()
        {
            Console.WriteLine("The lion rests 17 hours a day.");
        }
        void IPredator.Sound()
        {
            Console.WriteLine("The lion roars like a mighty ruler.");
        }
    }
    class Cat : IPredator
    {
        void IPredator.Walk()
        {
            Console.WriteLine("The cat walk elegantly around the living room.");
        }
        void IPredator.Run()
        {
            Console.WriteLine("The cat runs like a lightning.");
        }
        void IPredator.Rest()
        {
            Console.WriteLine("The cat rests 19 hours a day.");
        }
        void IPredator.Sound()
        {
            Console.WriteLine("The cat purrs softly.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat mycat = new Cat();
            IPredator cat = mycat;
            cat.Rest();
            IPredator lion = new Lion();
            lion.Run();
            Tiger wildtiger = new Tiger();
            IPredator tiger = wildtiger;
            tiger.Sound();
        }
    }
}
