using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26t10
{
    class Program
    {
        
        public static double mulpow(int num)
        {
            //טענת כניסה : הפעולה מקבלת מספר שלם
            //טענת יציאה : הפעולה מחזירה את סכום ריבוע המספרים הזוגיים והכפלת המספרים האי זוגיים בשתיים עד המספר כולל
            double num2 = 0;
            if (num==1)
            {
                return 2;
            }
            else if (num%2 == 0)
            {
                num2 = Math.Pow(num, 2);
                return (mulpow(num-1)) + num2 ;
            }
            else if (num%2 !=0)
            {
                num2 = num * 2;
                return mulpow(num-1) + num2;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(mulpow(4));
        }
    }
}
