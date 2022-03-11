using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //            Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            //*Test Data:
            //            *Enter the First number: 10
            //           * Enter the Second number: 15
            //           * Enter the third number: 20
            //           * Enter the four number: 30
            //         * Expected Output:
            //            *The average of 10, 15, 20 and 30 is: 18

            double first, second, third, fourth;

            Console.WriteLine("\n\nEnter your first number:\n");
            first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter your second number:\n");
            second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter your thid number:\n");
            third = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter your fourth number:\n");
            fourth = Convert.ToDouble(Console.ReadLine());
            double result = (first + second + third + fourth) / 4;
            Console.WriteLine("\nThe average of {0}, {1}, {2}, {3} is : {4} ", first, second, third, fourth, result);

        }
    }

}