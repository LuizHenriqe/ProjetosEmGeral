using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entites;
using Course.Entites.Enums;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();


            Console.Write("Enter the num of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");

                Console.Write("Rectangle or Circle (r/c)? ");
                string rOrC = Console.ReadLine();

                Console.Write("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(rOrC.ToLower() == "r")
                {
                    Console.Write("Width: ");
                    double w = double.Parse(Console.ReadLine());

                    Console.Write("Height: ");
                    double h = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(w, h, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(radius, color));
                }

            }

            Console.WriteLine("Shape Areas: ");
            foreach(Shape sp in list)
            {
                Console.WriteLine($"{sp.Area().ToString("F2")}");
            }
        }
    }
}
