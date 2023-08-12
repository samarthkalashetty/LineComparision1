using System;

namespace LineComparison
{
    class UC4
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        class Line : IComparable<Line>
        {
            public Point StartPoint { get; }
            public Point EndPoint { get; }

            public double Length => Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + Math.Pow(EndPoint.Y - StartPoint.Y, 2));

            public Line(Point startPoint, Point endPoint)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
            }

            public int CompareTo(Line other)
            {
                double thisLength = Length;
                double otherLength = other.Length;

                if (thisLength < otherLength)
                    return -1;
                else if (thisLength > otherLength)
                    return 1;
                else
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            Point startPoint1 = new Point(0, 0);
            Point endPoint1 = new Point(3, 4);
            Line line1 = new Line(startPoint1, endPoint1);

            Point startPoint2 = new Point(0, 0);
            Point endPoint2 = new Point(5, 12);
            Line line2 = new Line(startPoint2, endPoint2);

            Point startPoint3 = new Point(0, 0);
            Point endPoint3 = new Point(1, 1);
            Line line3 = new Line(startPoint3, endPoint3);

            int comparison1to2 = line1.CompareTo(line2);
            int comparison2to1 = line2.CompareTo(line1);
            int comparison1to3 = line1.CompareTo(line3);

            Console.WriteLine($"Comparison between Line 1 and Line 2: {comparison1to2}");
            Console.WriteLine($"Comparison between Line 2 and Line 1: {comparison2to1}");
            Console.WriteLine($"Comparison between Line 1 and Line 3: {comparison1to3}");
        }
    }
}