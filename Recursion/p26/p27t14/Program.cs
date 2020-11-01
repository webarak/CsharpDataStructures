using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p27t14
{
    class Program
    {
        public static double sum(double[] a, int index)
        {
            //טענת כניסה : הפעולה מקבלת מערך מספרים ואינדקס במערך
            //טענת יציאה : הפעולה מחזירה את סכום האיברים עד האיבר שבאינדקס שהתקבל
            if (index == -1)
            {
                return 0;
            }
            else
            {
                return sum(a, index - 1) + a[index];
            }
        }
        static void Main(string[] args)
        {
            double[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(sum(a,2));
        }
    }
}
