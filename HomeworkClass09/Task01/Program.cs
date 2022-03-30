using System;
using System.Collections.Generic;
using System.Linq;
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1
            //*Give the user an option to input 5 numbers
            //* Store all numbers in a QUEUE
            //*When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

            Queue<int> intQueue = new Queue<int>();

            while (intQueue.Count < 5)
            {
                Console.Write("Please enter  whole number:");
                bool success = int.TryParse(Console.ReadLine(), out int input);
                if(success)
                {
                    intQueue.Enqueue(input);
                   
                } else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.WriteLine("User's entered numbers are :");
            foreach (var number in intQueue)
            {
                Console.Write(number + " ");
            }
        }
    }
}
