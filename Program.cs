using System;

namespace LineComparison
{
    class UC3
    {
        class Line : IComparable<Line>
        {
            public double X1 { get; set; }
            public double Y1 { get; set; }
            public double X2 { get; set; }
            public double Y2 { get; set; }

            public double Length => Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

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
            Line line1 = new Line { X1 = 0, Y1 = 0, X2 = 3, Y2 = 4 };
            Line line2 = new Line { X1 = 0, Y1 = 0, X2 = 5, Y2 = 12 };
            Line line3 = new Line { X1 = 0, Y1 = 0, X2 = 1, Y2 = 1 };

            int comparison1to2 = line1.CompareTo(line2);
            int comparison2to1 = line2.CompareTo(line1);
            int comparison1to3 = line1.CompareTo(line3);

            Console.WriteLine($"Comparison between Line 1 and Line 2: {comparison1to2}");
            Console.WriteLine($"Comparison between Line 2 and Line 1: {comparison2to1}");
            Console.WriteLine($"Comparison between Line 1 and Line 3: {comparison1to3}");
        }
    }
}