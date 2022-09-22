using System;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Which animal do you want to hear?");
            var choice = Console.ReadLine();

            Animal animal = null;

            if (choice == "1")
            {
                animal = new Pig();
            }
            else if (choice == "2")
            {
                animal = new Dog();
            }
            else if (choice == "3")
            {
                animal = new Bird();
            }
            else if (choice == "4")
            {
                animal = new Cat();
            }
            else if (choice == "5")
            {
                animal = new Hamster();
            }

            animal?.MakeNoise();
            animal?.Sleep();
        }
    }
}
