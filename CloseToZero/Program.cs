using System;
using System.Collections.Generic;
using System.Linq;

namespace CloseToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * return the closest number to zero
             */
            List<int> xs = new List<int>() {-23,190,4,5,-9,-92,7,89 }; 
            Console.WriteLine( "The closest number to zero is " + Closest(xs));
            Console.Read();
        }

        private static int Closest(List<int> xs)
        {
            List<int> neg = new List<int>(), pos = new List<int>();
            foreach (int i in xs)
            {
                if (i == 0)
                {
                    return 0;
                }
                if (i < 0)
                {
                    neg.Add(i);
                }
                else
                { 
                    pos.Add(i);
                }
            }

            if (neg.Any() == false)
            { 
                return pos.Min();
            }
            else if (pos.Any() == false)
            { 
                return neg.Max(); 
            }
            else
            {
            return (Math.Abs(neg.Max()) <= pos.Min() ? neg.Max() : pos.Min());
            }
        }
    }
}
