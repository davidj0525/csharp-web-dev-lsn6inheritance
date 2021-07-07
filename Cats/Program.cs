using System;
using Cats;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try out your skills with inheritance here!

            HouseCat stella = new HouseCat("Stella", 12.0);


            Console.WriteLine(stella.Noise());

            stella.Sleep();

            Console.WriteLine(stella.Noise());

            stella.Eat();
            Console.WriteLine(stella.Tired);


        }
    }
}
