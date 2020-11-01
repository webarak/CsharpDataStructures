using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26t4
{
    class Program
    {
        public static int NumberOfDigits(int num)
        {
            //טענת כניסה: פעולה המקבלת מספר שלם
            //טענת יציאה : הפעולה מחזירה את מספר הספרות במספר השלם
            
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return NumberOfDigits(num/10) + 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfDigits(1234));
        }
    }
}
