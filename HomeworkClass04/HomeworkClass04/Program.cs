using System;

namespace HomeworkClass04
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1
            //*Take one string from the input and print its last 5 characters.

            Console.WriteLine("Please enter   noun , adjective or  verb:");

            LastFive(Console.ReadLine());
            }

        static string LastFive ( string input)
        {
            string theLastFive = input.Substring(input.Length - 5);
            Console.WriteLine($"The last five characters of the  {input} are {theLastFive}.");
            return theLastFive;
        }
    }
}
