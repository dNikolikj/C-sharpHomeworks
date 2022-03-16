using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 2
            //*Take a sentence as input and find its words.

            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();

            string[] splittedString = sentence.Split(" ");

            for (int i = 0; i < splittedString.Length; i++)
            {
                Console.WriteLine($"The number words cointaining your entered sentence is {splittedString.Length} an they are: {i + 1}: {splittedString[i]} ");
            }
               
        }
    }
}
