using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a Mad Libs app
            Author: Jonas Bernhard Tuft
            */

            // Let the user know that the program is starting:
            Console.WriteLine("Welcome to Mad Libs!");

            // Define user input and variables:
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Get adjectives from the user:
            Console.Write("Enter a color: ");
            string color = Console.ReadLine();
            Console.Write("Enter a feeling: ");
            string feeling = Console.ReadLine();
            Console.Write("Enter a texture: ");
            string texture = Console.ReadLine();

            // Get a verb from the user:
            Console.Write("Enter an action: ");
            string action = Console.ReadLine();

            // Get two nouns:
            Console.Write("Enter a place: ");
            string place = Console.ReadLine();
            Console.Write("Enter a thing: ");
            string thing = Console.ReadLine();

            // Get additional inputs:
            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();
            Console.Write("Enter a food item: ");
            string food = Console.ReadLine();
            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();
            Console.Write("Enter a country: ");
            string country = Console.ReadLine();
            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();

            // Create the Mad Libs story using the user inputs:
            string story = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {color} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {action} to the rhythm of the {place}, which made all the {fruit}s very {texture}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {thing}s ruled the world.";

            // Print the story:
            Console.WriteLine("\n");
            Console.WriteLine(story);
        }
    }
}
