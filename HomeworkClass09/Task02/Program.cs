using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 2
            //*Create a list of ten numbers.
            //* Use LINQ to select in a list of the squares of all the numbers in the list from above.

            List<int> listOfTenNumbers = new List<int> { 2, 5, 4, 8, 5, 3, 4, 9, 3, 10 };
            var squaresOfUpperList = from number in listOfTenNumbers
                                     select number * number;
            var methodSyntax = listOfTenNumbers.Select((d) => d * d).ToList();


            Console.WriteLine("Squares of the first list's numbers (using query syntax) are :");
            foreach (var number in squaresOfUpperList)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nSquares of the first list's (using method syntax) numbers are :");
            foreach (var number in methodSyntax)
            {
                Console.Write(number + " ");
            }
        }
    }
}
