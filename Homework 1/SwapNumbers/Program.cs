using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
            //      Please find example below:
            //      *Test Data:
            //            *Input the First Number: 5
            //           * Input the Second Number: 8
            //         * Expected Output:
            //            *After Swapping:
            //            *First Number: 8
            //           * Second Number: 5
            int first, second, temp;
            Console.WriteLine("\n\nFunction : To swap the values of two integer numbers :\n");
            Console.WriteLine("Enter your first number:");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            second = Convert.ToInt32(Console.ReadLine());

            temp = first;
            first = second;
            second = temp;

            Console.WriteLine("\nAfter Swapping : ");
            Console.WriteLine("\nFirst Number : " + first);
            Console.WriteLine("\nSecond Number : " + second);

        }
    }
}
