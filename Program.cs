using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Author: Jayla Bullard

            //Story Title:
            string title = "Mad Libs";

            Console.WriteLine(title);

            //Program has started:

            Console.WriteLine("Let's start collecting data for Mad Libs!");
            Console.ReadLine();


            //User input and variables:

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter first adjective: ");
            string adj1 = Console.ReadLine();

            Console.Write("Enter second adjective: ");
            string adj2 = Console.ReadLine();

            Console.Write("Enter third adjective: ");
            string adj3 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter first noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter second noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            string food = Console.ReadLine();

            Console.Write("Enter fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Enter a superhero : ");
            string superhero = Console.ReadLine();

            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Enter a year: ");
            string year = Console.ReadLine();

            Console.WriteLine("Mad Libs has begun!");
            object country = null;
            string story = $"This morning {userName} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {userName} texted {superhero}, who flew {userName} to {country} and dropped {userName} in a puddle of frozen {dessert}. {userName} woke up in the year {year}, in a world where {noun2}s ruled the world.";

            Console.WriteLine(story);
        }
    }
}
