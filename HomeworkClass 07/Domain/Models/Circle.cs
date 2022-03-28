using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override void GetPerimetar()
        {
            double result = Math.PI * Radius * 2;
            Console.WriteLine($"The perimeter of the circle is {result}cm2.");
        }

        public override void GetArea()
        {
            double result = Math.PI * Radius * Radius;
            Console.WriteLine($"The area of the circle is {result}cm2.");
        }
    }
}

