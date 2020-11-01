using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26t5
{
    class Program
    {
        public static int Mana(int num1, int num2)
        {
            //טענת כניסה : פעולה המקבלת שני מספרים שלמים 
            //טענת יציאה : הפעולה מחזירה את המנה השלמה של שני המספרים
            if (num1<num2)
            {
                return 0;
            }
            else
            {
                return Mana(num1 - num2, num2) + 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Mana(8,3));
        }
    }
}
