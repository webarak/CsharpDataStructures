using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26t6
{
    class Program
    {
        public static int MOdolo(int num1, int num2)
        {
            //טענת כניסה : פעולה המקבלת שני מספרים שלמים 
            //טענת יציאה : הפעולה מחזירה את שארית המנה של שני המספרים
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return MOdolo(num1 - num2, num2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MOdolo(8, 3));
        }
    }
}
