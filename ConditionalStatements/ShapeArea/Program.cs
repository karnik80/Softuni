using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            double area = 0;

            if(shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if(shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if(shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = (radius * radius) * Math.PI;
            }
            else if(shape == "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = (lenght * height) / 2;
            }
            else
            {

            }

            area = Math.Round(area, 3);
            Console.WriteLine($"{area:F3}");
        }
    }
}
