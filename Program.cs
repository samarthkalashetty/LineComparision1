using System;

namespace LineLengthCalculation
{
    class UC1
    {
        static double CalculateLineLength(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Length Calculation!");

            Console.Write("Enter x-coordinate of the first point: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter y-coordinate of the first point: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x-coordinate of the second point: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter y-coordinate of the second point: ");
            double y2 = double.Parse(Console.ReadLine());

            double lineLength = CalculateLineLength(x1, y1, x2, y2);

            Console.WriteLine($"The length of the line between ({x1}, {y1}) and ({x2}, {y2}) is: {lineLength}");
        }
    }
}