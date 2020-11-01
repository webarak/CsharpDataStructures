using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26t12
{
    class Program
    {
        public static int sumultiply(int num1, int num2,int num3, int sumul)
        {
            //טענת כניסה : הפעולה מקבלת שני מספרים שלמים
            //טענת יציאה : סכום המכפלות הקטנות מהמספר השני
            if (num1*num3 < num2)
            {
                sumul += num1 * num3;
                return sumultiply(num1, num2, num3 + 1, sumul);
            }
            else
            {
                return sumul;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sumultiply(4,20,1,0));
        }
    }
}
