using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //       Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.
            //* Test Data:
            //       *Enter the First number: 10
            //      * Enter the Second number: 15
            //      * Enter the Operation: +
            //    *Expected Output:
            //       *The result is: 25

            int firstInt, secondInt;
            char operation;
            Console.WriteLine("\n\nInput the first number:\n");
            firstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput operation:\n ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nInput the second number:\n");
            secondInt = Convert.ToInt32(Console.ReadLine());

                     

            //Console.WriteLine("{0} + {1} = {2}", firstInt, secondInt, firstInt + secondInt);
            //Console.WriteLine("{0} - {1} = {2}", firstInt, secondInt, firstInt - secondInt);
            //Console.WriteLine("{0} x {1} = {2}", firstInt, secondInt, firstInt * secondInt);
            //Console.WriteLine("{0} / {1} = {2}", firstInt, secondInt, firstInt / secondInt);
           

            if (operation == '+')
                Console.WriteLine("\n{0} + {1} = {2}", firstInt, secondInt, firstInt + secondInt);
            else if (operation == '-')
                Console.WriteLine("\n{0} - {1} = {2}", firstInt, secondInt, firstInt - secondInt);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("\n{0} * {1} = {2}", firstInt, secondInt, firstInt * secondInt);
            else if (operation == '/')
                Console.WriteLine("\n{0} / {1} = {2}", firstInt, secondInt, firstInt / secondInt);
            else
                Console.WriteLine("\nWrong Character");
        
    }
    }
}
