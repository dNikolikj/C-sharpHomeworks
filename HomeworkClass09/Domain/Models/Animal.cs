using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }




        public Animal ()
        {
            Gender = Gender.Female;
        }

        public Animal (string name, string color, int age, Gender gender)
        {
            Name = name;
            Color = color;
            Age = age;
            Gender = gender;

        }
    }
}
