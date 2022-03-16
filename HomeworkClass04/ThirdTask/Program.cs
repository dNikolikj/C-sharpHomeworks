using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 3
            //*Create a function that takes a number as input.This method should return the sum of the digits in the number.

            int number;

            Console.WriteLine("Enter a number to find the sum of the digits in that number.");
            
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter a number.");
               
            }
            getDigitSum(number);
        }


        static int getDigitSum(int digit)
        {
            int sum = 0;
            while (digit != 0)
            {
                int rem;
                digit = Math.DivRem(digit, 10, out rem);
                sum += rem;
            }
            Console.WriteLine($"The sum of the digits of the entered number is: {sum}");
            return sum;
            
           
    
        } 
    }

}
