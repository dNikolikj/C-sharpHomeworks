using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            ## Task 3
            //            Ask the user to enter a number as an input.Print all the numbers except the numbers divisible by 5.When you come to 80, the limit is                   reached.

            Console.WriteLine("Enter a whole number:");
            bool success = int.TryParse(Console.ReadLine(), out int input);

            if (success)
            {
                for (int i = 1; i <= input; i++)
                {
                    if (i % 5 == 0)
                    {
                        continue;
                    }
                    if (i == 80)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }
         
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
            }

        }
    }
}
