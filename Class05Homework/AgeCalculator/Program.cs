using System;

namespace AgeCalculator
{//## Task 1
 //*Make a method called AgeCalculator
 //* The method will have one input parameter, your birthday date
 //* The method should return your age
 //* Show the age of a user after he inputs a date

    //> Note: take into consideration if the birthday is today, after or before today
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthday date : month/day/year:");
            string birthdayDate = Console.ReadLine();
            DateTime parsedDateTime = DateTime.Parse(birthdayDate);



            var userInputAge = AgeCalculator(parsedDateTime);
            Console.WriteLine($"You are {userInputAge} years old.");
        }
        public static int AgeCalculator(DateTime birthDate)
        {
            {
                DateTime now = DateTime.Now;
                int age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                    age--;

                return age;
            }
        }
    }
}
