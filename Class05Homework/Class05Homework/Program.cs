using System;
using Class05Homework.Models;

//## Task 2
//*Create a class Human
//*Add properties: FirstName, LastName, Age
//* Create a method called GetPersonStats that returns the full name of the human as well as their age
//* Create an object human by asking the user to fill the required information(take first name, last name and age from user input)
//*Call the GetPersonStats method and print the result in the console after the object is created
namespace Class05Homework
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            string age = Console.ReadLine();
            int numAge = int.Parse(age);


            Human human = new Human();
            human.FirstName = firstName;
            human.LastName = lastName;
            human.Age = numAge;

            string description = human.GetPersonStats(human.FirstName, human.LastName, human.Age);
            Console.WriteLine(description);

        }
    }
}
