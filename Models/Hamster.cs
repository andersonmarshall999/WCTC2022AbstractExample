using System;

namespace AbstractExample.Models
{
    public class Hamster : Animal
    {
        public Hamster(string name)
        {
            Name = name;
        }

        public Hamster()
        {
            Name = "Hammy";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says squeak squeak");
        }

        public override void Sleep()
        {
            Console.WriteLine("MIMIMimimimi");
        }
    }
}