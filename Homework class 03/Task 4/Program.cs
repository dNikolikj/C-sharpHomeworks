using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //           ## Task 4
            //           *Make a new console application.
            //           * Create an array of 10 whole numbers(integers). 
            //           *Find the minimum and maximum and print them in the console.

            int[] arrayNumbers = new int[10];
            arrayNumbers[0] = 5;
            arrayNumbers[1] = 11;
            arrayNumbers[2] = 1;
            arrayNumbers[3] = 2;
            arrayNumbers[4] = 8;
            arrayNumbers[5] = 15;
            arrayNumbers[6] = 35;
            arrayNumbers[7] = 25;
            arrayNumbers[8] = 18;
            arrayNumbers[9] = 14;
            int maxValue = arrayNumbers[0];
            int minValue = arrayNumbers[0];
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                
                if (arrayNumbers[i] > maxValue)
                {
                    maxValue = arrayNumbers[i];
                } if (arrayNumbers[i] < minValue)
                {
                    minValue = arrayNumbers[i];
                }
                
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);


        }
    }
}
