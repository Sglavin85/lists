using System;
using System.Collections.Generic;

namespace lists
{
    public class Program
    {
        public static void Main()
        {

            //Practicing with List methods while working with the planets

            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            Console.WriteLine("Original Planet List:");
            planetList.ForEach(planet => Console.WriteLine(planet));


            List<string> newPlanets = new List<string>() { "Jupiter", "Saturn" };
            planetList.AddRange(newPlanets);
            Console.WriteLine("Planet List after adding the gas giants:");
            planetList.ForEach(planet => Console.WriteLine(planet));


            planetList.Add("Uranus");
            planetList.Add("Neptune");
            planetList.Add("Pluto");
            Console.WriteLine("Planet List after adding the last two planets:");
            planetList.ForEach(planet => Console.WriteLine(planet));

            List<string> insertedPlanets = new List<string>() { "Venus", "Earth" };
            planetList.InsertRange(1, insertedPlanets);
            Console.WriteLine("Full Planet List:");
            planetList.ForEach(planet => Console.WriteLine(planet));

            List<string> rockyPlantets = planetList.GetRange(0, 4);
            Console.WriteLine("The list of rocky plants:");
            rockyPlantets.ForEach(planet => Console.WriteLine(planet));


            planetList.Remove("Pluto");
            Console.WriteLine("Planet List after Pluto is removed");
            planetList.ForEach(planet => Console.WriteLine(planet));


            //Random Numbers Practice
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            Console.WriteLine("Original Numbers:");
            numbers.ForEach(number => Console.WriteLine(number));

            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers.Contains(i))
                {
                    Console.WriteLine($"numbers list contains {i}");
                }
                else
                {
                    Console.WriteLine($"numbers list does not contain {i}");
                }

            }
        }
    }
}