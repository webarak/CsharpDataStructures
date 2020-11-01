using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p28t27
{
    class Program
    {
        public static void kefelboard(int num1, int num2)
        {
            //טענת כניסה : הפעולה מקבלת שני מספרים, 1 ו1 המייצגים את המספר הראשון בטור ובשורה בלוח הכפל
            //טענת יציאה : הפעולה מדפיסה את לוח הכפל
            if (num1 < 11)
            {
                if (num2 < 11)
                {
                    Console.Write("{0,5}", num1 * num2);
                    kefelboard(num1, num2 + 1);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    kefelboard(num1 + 1, 1);
                }
            }
        }
        static void Main(string[] args)
        {
            kefelboard(1, 1);
        }
    }
}
