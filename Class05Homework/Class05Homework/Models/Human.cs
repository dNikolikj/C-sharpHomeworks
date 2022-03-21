using System;
using System.Collections.Generic;
using System.Text;





namespace Class05Homework.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }



        public string GetPersonStats(string firstName , string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

            return $"{firstName} {lastName} is {age} years old.";
        }
    }
}
