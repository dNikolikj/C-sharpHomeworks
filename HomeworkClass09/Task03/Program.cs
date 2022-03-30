using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Enums;
using Domain.Models;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 3
            //Create a class Animal. Each Animal has name, color, age and Gender.Use enum for Gender.
            //* Find the names of all the animals aged 5 or more
            //* Find all the names of the animals that start with 'A'
            //* Find all male, brown animals
            //* Find the first animal whose name is longer than 10 characters

            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Animal("Anabel", "Brown", 10, Gender.Male));
            animalList.Add(new Animal("Antiona", "Brown", 4, Gender.Female));
            animalList.Add(new Animal("Freud", "White", 3, Gender.Male));
            animalList.Add(new Animal("Mailo", "Brown", 5, Gender.Male));
            animalList.Add(new Animal("JackRusselTerrier", "Grey", 9, Gender.Male));

            List<string> fiveOrMore = animalList.Where((dog) => dog.Age >= 5).Select((dog) => $"{dog.Name}-{dog.Color}").ToList();
            Console.WriteLine("Animals aged 5 or more:");
            foreach (var animal in fiveOrMore)
            {
                Console.WriteLine(animal);
            }

            var animalsStatsWithA = from animal in animalList
                                    where animal.Name.StartsWith("A")
                                    select animal.Name;

            Console.WriteLine("Animals whose name starts with A:");
            foreach (var animal in animalsStatsWithA)
            {
                Console.WriteLine(animal);
            }

            var allMaleBrownAnimals = from animal in animalList
                                      where animal.Gender == Gender.Male && animal.Color == "Brown"
                                      select animal.Name;

            Console.WriteLine("All male , brown animals:");
            foreach (var animal in allMaleBrownAnimals)
            {
                Console.WriteLine(animal);
            }



            var firstElementEqual10OrMore = animalList.Where((animal) => animal.Name.Length >= 10).Select((animal) => animal.Name).ToList();
            Console.WriteLine("Animal whose name is longer than 10 characters");
            foreach (var name in firstElementEqual10OrMore)
            {
                Console.WriteLine(name);
            }

            // Another way 
            var firstOrDefault = animalList.FirstOrDefault((n) => n.Name.Length >= 10);
            Console.WriteLine("First animal that that the name is equal or longer than ten:");
            Console.WriteLine($"{firstOrDefault.Name}");
            
            
        }
    }
}
