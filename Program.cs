using System;

namespace LineEqualityCheck
{
    class UC2
    {
        class Line
        {
            public double X1 { get; set; }
            public double Y1 { get; set; }
            public double X2 { get; set; }
            public double Y2 { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                Line other = (Line)obj;
                return X1 == other.X1 && Y1 == other.Y1 && X2 == other.X2 && Y2 == other.Y2;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(X1, Y1, X2, Y2);
            }
        }

        static void Main(string[] args)
        {
            Line line1 = new Line { X1 = 0, Y1 = 0, X2 = 1, Y2 = 1 };
            Line line2 = new Line { X1 = 0, Y1 = 0, X2 = 1, Y2 = 1 };
            Line line3 = new Line { X1 = 2, Y1 = 2, X2 = 3, Y2 = 3 };

            bool areLinesEqual1 = line1.Equals(line2);
            bool areLinesEqual2 = line1.Equals(line3);

            Console.WriteLine($"Line 1 and Line 2 are equal: {areLinesEqual1}");
            Console.WriteLine($"Line 1 and Line 3 are equal: {areLinesEqual2}");
        }
    }
}