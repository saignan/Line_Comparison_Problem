using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Problem
{
    public class UseCase3
    {
        public static void UC3()
        {
            // Define the two lines
            Linee line1 = new Linee(new Pointt(6, 5), new Pointt(7, 4));
            Linee line2 = new Linee(new Pointt(7, 6), new Pointt(8, 5));

            // Compare the lines using the CompareTo method
            int resultt = line1.CompareTo(line2);

            // Output the comparison result
            if (resultt == 0)
            {
                Console.WriteLine("Line 1 is equal to Line 2.");
            }
            else if (resultt < 0)
            {
                Console.WriteLine("Line 1 is less than Line 2.");
            }
            else if (resultt > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2.");
            }

            Console.ReadLine();
        }
    }

    class Pointt
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Pointt(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Linee : IComparable<Linee>
    {
        public Pointt Start { get; set; }
        public Pointt End { get; set; }

        public Linee(Pointt start, Pointt end)
        {
            Start = start;
            End = end;
        }


        public int CompareTo(Linee other)
        {
            // Get the lengths of both lines
            double length1 = Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
            double length2 = Math.Sqrt(Math.Pow(other.End.X - other.Start.X, 2) + Math.Pow(other.End.Y - other.Start.Y, 2));

            // Compare the lengths using the CompareTo method
            return length1.CompareTo(length2);
        }

    }
   
}