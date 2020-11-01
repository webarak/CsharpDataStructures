using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p26t3
{
    class Program
    {
        public static int Multiplyodd(int num)
        {
            //טענת כניסה : פעולה מהקבלת מספר שלם
            //טענת יציאה : הפעולה מחזירה את מכפלת המסרים האי זוגיים מ1 ועד המספר
            if (num == 1)
            {
                return 1;
            }
            else
            {
                if (num % 2 == 0)
                {
                    return Multiplyodd(num - 1);
                }
                else
                {
                    return Multiplyodd(num - 2)*num;
                }
            }

        }
        static void Main(string[] args)
        {
            int x = Multiplyodd(6);
            Console.WriteLine(x);
        }
    }
}
