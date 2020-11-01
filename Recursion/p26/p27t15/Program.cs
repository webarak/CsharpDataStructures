using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p27t15
{
    class Program
    {
        public static int numberofeven(double [] a, int index)
        {
            //טענת כניסה : הפעולה מקבלת מערך מספרים ואינדקס במערך
            //טענת יציאה : הפעולה מחזירה את כמות המספרים החיוביים עד המספר שבאינדקס שהתקבל
            if (index == -1)
            {
                return 0;
            }
            else
            {
                if (a[index] >= 0)
                {
                    return numberofeven(a, index - 1) + 1;
                }
                else
                {
                    return numberofeven(a, index - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            double[] a = { 1, 2, 3, -4, 5, 6, 7, 8 };
            Console.WriteLine(numberofeven(a,6));
        }
    }
}
