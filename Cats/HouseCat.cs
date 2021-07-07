using System;

namespace Cats
{
    public class HouseCat : Cat
    {
        public string Name { get; set; }
        public string Species { get; } = "Felis catus";


        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        // On this line, write a constructor that uses the no-arg constructor in the Cat class.

        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }

        public override string Noise()
        {
            if (IsSatisfied())
            {
                return "Hello, my name is " + Name + "!";
            }
            else
            {
                return "I'm not satisfied, because I'm a fucking cat.";
            }
        }
        public string Purr()
        {
            return "I'm a housecat";
        }
    }
}
