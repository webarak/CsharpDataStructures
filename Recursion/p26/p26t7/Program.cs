using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26t7
{
    class Program
    {
        public static bool multiplycorrect(int num1, int num2)
        {
            //טענת כניסה : הפעולה מקבלת 2 מספרים שלמים
            //טענת יציאה : הפעולה מחזירה אמת כאשר המספרים מתחלקים אחד בשני ושקר אם אחרת
            if (num1 == 0)
            {
                return true;
            }
            else if (num1<num2 && num1!= 0)
            {
                return false;
            }
            else
            {
                return multiplycorrect(num1 - num2, num2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(multiplycorrect(9,3));
        }
    }
}
