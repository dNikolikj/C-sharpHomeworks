using System;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 5
            // *Create an array of integers. Get the number of elements and the values of the elements from input.
            //* Find how many times there are two 3 next to each other.
            //*Example: 
            //	*Enter number of elements: 7
            //   * Enter first element: 9
            //   * Enter second element: 3
            //   * Enter first element: 3
            //   * Enter first element: 4
            //   * Enter first element: 3
            //   * Enter first element: 3
            //   * Enter first element: 3
            //   * Three times there are threes next to each other.


            int elements;
            Console.WriteLine("Enter only numbers 1-9:");
            Console.WriteLine("Please enter the number of elements: ");

            while (!int.TryParse(Console.ReadLine(), out elements))
            {
                Console.WriteLine("Invalid input, enter a number.");

            }

            int[] arrayOfIntegeres = new int[elements];

            for (int i = 0; i < arrayOfIntegeres.Length; i++)
            {
                int input;
                Console.WriteLine($"Please enter value number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input, enter a number.");
                    Console.WriteLine($"Please enter value number {i + 1}: ");
                }

                arrayOfIntegeres[i] = input;


                int counter = 0;

                for (int index = 0; index < arrayOfIntegeres.Length - 1; index++)
                {
                    if (arrayOfIntegeres[index] == 3 && arrayOfIntegeres[index + 1] == 3)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"There are {counter} instances of three next to each other.");
                
            }


        }

    }

    }







