using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Line_Comparison_Problem
{
    abstract class UseCase4
    {
        public abstract double twoLines(double x1, double y1, double x2, double y2);
    }
    class child1 : UseCase4
    {
        public override double twoLines(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
        }
    }
    class UC4
    {
        public static void UC()
        {
            child1 c = new child1();
            double length1 = c.twoLines(7, 10, 8, 9);
            double length2 = c.twoLines(6, 15, 16, 8);
            int status = length1.CompareTo(length2);
            if (status > 0)
                Console.WriteLine("{0} is greater than {1}", length1, length2);
            else if (status < 0)
                Console.WriteLine("{0} is lesser than {1}", length1, length2);
            else
                Console.WriteLine("{0} is equal to {1}", length1, length2);
        }
    }
}
