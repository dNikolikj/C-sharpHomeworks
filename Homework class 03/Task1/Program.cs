using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1
            //            Create new console application “FindStatistics”. Input 2 numbers.If the two of them are even, print their sum,
            //              if one of them is odd, print their difference, if the two off them are odd, multiply them. Don't print just the result,
            //              but also the whole operation.Treat zero as even.
            //              Please find example below:
            //              *Test Data:
            //              *Input the First Number: 8
            //             * Input the Second Number: 5
            //             * Expected Output:
            //              *One of the numbers is odd.The operation and result are 8 - 5 = 3.



            Console.WriteLine("Enter the first number:");
            bool success1 = int.TryParse(Console.ReadLine(), out int input1);
            Console.WriteLine("Enter the second number:");
            bool success2 = int.TryParse(Console.ReadLine(), out int input2);
            
            if (success1 && success2)
            {
                int result;
                if (input1 % 2 == 0 && input2 % 2 == 0 && input1 == 0 || input2 == 0)
                {
                    result = input1 + input2;
                    Console.WriteLine(" The  numbers are even. The operation and result are {0} + {1} = {2}", input1, input2, input1 + input2);
                }
               

                else if(input1 % 2 != 0 && input2 % 2 == 0)
                {
                    result = input1 - input2;
                    Console.WriteLine(" One of the numbers is odd. The operation and result are {0} - {1} = {2}", input1, input2, input1 - input2);
                }
                else if (input1 % 2 != 0 && input2 % 2 != 0)
                {
                    result = input1 * input2;
                    Console.WriteLine(" The numbers are odd. The operation and result are {0} * {1} = {2}", input1, input2, input1 * input2);
                }


            }
            else
            {
                Console.WriteLine("Invalid input. Please enter two whole numbers.");
            }


        }
    }
}
