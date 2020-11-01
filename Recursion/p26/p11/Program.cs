using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p11
{
    class Program
    {
        public static int power(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return power(a, b-1)*a;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(power(2,4));
        }
    }
}
