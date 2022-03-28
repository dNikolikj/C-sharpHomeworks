using System;
using Domain.Models;
namespace HomeworkClass07
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle ourCircle = new Circle();
            ourCircle.Radius = 10;
            ourCircle.Name = "circle";
            ourCircle.Color = "blue";
            ourCircle.Position = new int[] { 50, 55 };
            ourCircle.Print();
            ourCircle.GetArea();
            ourCircle.GetPerimetar();
            ourCircle.Move();


            Rectangle ourRectangle = new Rectangle();

            ourRectangle.Name = "rectagle";
            ourRectangle.Color = "green";
            ourRectangle.SideA = 14;
            ourRectangle.SideB = 10;
            ourRectangle.Position = new int[] { 8, 15 };

            ourRectangle.Print();
            ourRectangle.GetArea();
            ourRectangle.GetPerimetar();
            ourRectangle.Move();


        }
    }
}
