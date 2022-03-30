using System;
using Domain.Enums;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Class08Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Contractor[] contractors = new Contractor[]
            {
                new Contractor {FirstName= "Darko", LastName= "Nikolikj"},
                new Contractor {FirstName = "Jelena", LastName= "Nikolikj"}
            };

            Manager[] managers = new Manager[]
            {
                new Manager{FirstName= "Borkica", LastName= "Bozinovska"},
                new Manager{FirstName ="Ljubica", LastName="Andonovska"}
            };

           

            SalesPerson salesPerson = new SalesPerson("Johnny", "Deep");

            List<object> allEmployees = new List<object>() { contractors, managers, salesPerson };

            // OBID DA GI IZLISTAM SITE OD allEmplyees  KAKO PLUS OD ONA SHTO SE BARASHE VO ZADACATA NO NE USPEAV,
            // DOKOLKU MOZE DA MI POSOCITE KAKO BI GO STORIL TOA,
            // ZA DA GO KOREGIRAM KODOT VO SLEDNITE NEKOLKU LINII...

            //var groupBy = from employee in allEmployees
            //              group employee by employee.Firstname into newGroup
            //              select newGroup;
            //foreach (var newGroup in allEmployees)
            //{
            //    foreach (var employee  in newGroup)
            //    {
            //        Console.WriteLine($"{employee.FirstName} - {employee.LastName}");
            //    }
            //}



            CEO ceoBogdan = new CEO("Bogdan", "Bogdanovic", 2000, 45, new string[] { "Robert Sazdovski", "Marko Marinkovikj", "Donovan Mitchell", "Steph Curry", "Toni Petkovski" });

            
            ceoBogdan.PrintInfo();
            ceoBogdan.PrintEmployees();
            ceoBogdan.GetSalary();
        }
    }
}

