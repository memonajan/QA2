using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJAssignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(decimal tri1, decimal tri2, decimal tri3)
        {
            if ((tri1 + tri2 > tri3) && (tri2 + tri3 > tri1) && (tri1 + tri3 > tri2))
            {
                Console.WriteLine("These sides form a triangle");
                //If two sides have the same length,
                //and the angles opposite the equal sides are
                if (tri1 != tri2 && tri1 != tri3 && tri2 != tri3)
                {

                    Console.WriteLine("It's an scalene triangle.");
                }

                //all three sides and angles are equal
                else if ((tri1 == tri2) && (tri2 == tri3))
                {
                    Console.WriteLine("It's an equilateral triangle");
                }

                //no two sides are equal
                else
                {
                    Console.WriteLine("It's an isosceles triangle.");
                }
            }
            else
            {
                Console.WriteLine("These sides do not form a triangle");
            }
           
           
            return "";
        }
    }
}
