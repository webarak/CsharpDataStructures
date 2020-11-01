using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26t11
{
    class Program
    {
        public static double maatefet(int num)
        {
            return plushoresh(num, 1, 0, true);
        }
        public static double plushoresh(int num, int num1, double sum, bool shoresh)
        {
            if (num1<=num)
            {
                if(shoresh)
                {
                    sum += num1;
                    return plushoresh(num, num1 + 2, sum, false);
                }
                else
                {
                    sum -= Math.Sqrt(num1);
                    return plushoresh(num, num1 + 2, sum, true);
                }
            }
            else
            {
                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(maatefet(5));
        }
    }
}
