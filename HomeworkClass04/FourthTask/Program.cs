using System;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 4
            //*Create four methods for calculation sum, substract, multiplication and division of two numbers.
            //* Create a function called calculator, that has three parameters.The first one is operator and then two numbers.
            //* Depending on the value of the operator, call the corresponding function from the four ones
            //                                                                         from above.

            double num1;
            double num2;
            string operation;
            string result;


            Console.WriteLine("Please enter your first number:");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                
                Console.Write("Please enter your first number: ");
            }

            Console.Write("\nPlease enter your second number: \n");

            while (!double.TryParse(Console.ReadLine(), out num2))
            {
              
                Console.Write("\nPlease enter your second number: \n");
            }

            Console.Write("\nPlease enter your operation:\n  (+, -, *, / ) \n");
            operation = Console.ReadLine();
            result = SimpleCalculator(num1, num2, operation);
            Console.WriteLine(result);

        }


        static string SimpleCalculator(double num1, double num2, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = Sum(num1, num2);
                    break;
                case "-":
                    result = Substract(num1, num2);
                    break;
                case "/":
                    result = Division(num1, num2);
                    break;
                case "*":
                    result = Multiplication(num1, num2);
                    break;
                default:
                    return $"Enter a valid operation.";
                    
            }
            return $"{num1} {operation} {num2} = {result}";
        }
            

        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Substract(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiplication (double num1, double num2)
        {
            return num1 * num2;
        }

        static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        
    }
}
