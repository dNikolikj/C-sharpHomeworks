using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Rectangle:Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }




        public override void GetPerimetar()
        {
            double result = 2 * (SideA + SideB);
            Console.WriteLine($"The perimeter of the rectangle is {result}cm2.");
        }
        public override void GetArea()
        {
           double result = SideA * SideB;
            Console.WriteLine($"The area of the rectangle is {result}cm2.");
        }

       
    }
}
