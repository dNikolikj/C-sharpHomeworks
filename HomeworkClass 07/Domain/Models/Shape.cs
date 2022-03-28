using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Shape
    {
        public string name;
        public string color;
        public int[] Position { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.ToLower() == "Circle" || value.ToLower() == "Rectangle")
                {
                    name = value;
                    Console.WriteLine($"{Name}");
                }
                else
                {
                    name = value;
                    
                }

            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value.ToLower() == "red" || value.ToLower() == "blue" || value.ToLower() == "green")
                {
                    color = value;
                    
                }
                else
                {
                    color = null;
                }

            }
        }


        public Shape() { }

       

        public virtual void GetArea()
        {
            Console.WriteLine("There is no yet any implementation of this method, in the derrived classes will be overwritten."); 
        }

        public virtual void GetPerimetar()
        {
            Console.WriteLine("There is no yet any implementation of this method, in the derrived classes will be overwritten.");
        }


        public void Move()
        {
            int[] userPositioning = new int[0];
            int index = 0;
            foreach (int coordinate in Position)
            {
                Array.Resize(ref userPositioning, userPositioning.Length + 1);
                userPositioning[index] = coordinate + 5;
                index++;
            }

            //foreach (int position in userPositioning)
            //{
            //    Console.WriteLine($"x:{position} , y:{position}");
            //}
            for (int i = 0; i < userPositioning.Length; i++)
            {
                Console.WriteLine($"Position for x: {userPositioning[i]}");
                for (int j = 0; j < userPositioning.Length; j++)
                {
                    Console.WriteLine($"Position for y: {userPositioning[j]}");
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"You have created {Name} which is colored {Color}.");
        }
    }



}

