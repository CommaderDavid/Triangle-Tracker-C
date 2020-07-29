using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
    public class Program
    {
        public static void Main()       // program entry point
        {
            Console.WriteLine("Give me the first side of your triangle.");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me your second side of your triangle.");
            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me the third side of your triangle.");
            int side3 = int.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(side1, side2, side3);

            triangle.GetTriangleType();
        }
    }
}