using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CEO:Employee
    {
        private double SharesPrice { get; set; }
        public string[] Employees { get; set; }
        public int Shares { get; set; }


        public CEO(string firstName, string lastName, double salary, int shares, string[] employees)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Shares = shares;
            Employees = employees;
        }

        public double AddSharesPrice(double number)
        {
            SharesPrice += number;

            return SharesPrice;
        }
        public override double GetSalary()
        {
            Salary += (Shares * SharesPrice);
            return Salary;
        }

        public void PrintEmployees()
        {
            Console.WriteLine($"These are all the employees working for these company:");

            foreach (string employees in Employees)
            {
                Console.WriteLine(employees);

            }
        }
    }
}
