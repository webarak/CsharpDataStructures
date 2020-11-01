using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26t9
{
    class Program
    {
        public static bool typedigits(int num)
        {
            //טענת כניסה : הפעולה מקבלת מספר שלם
            //טענת יציאה : הפעולה מחזירה אמת אם כל ספרות המספר זוגיות או אי זוגיות, ושקר אם לא

            if (num / 10 != 0)
            {
                if (((num % 10) % 2) == (((num / 10) % 10) % 2))
                {
                    return typedigits(num / 10);
                }
                else if (((num % 10) % 2) != (((num / 10) % 10) % 2))
                {
                    return false;
                }
                else
                    return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(typedigits(11777));
        }
    }
}
