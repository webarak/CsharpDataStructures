using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex1___9._9._19
{
    class Program
    {
        public static int azeret(int num)
        {
            //טענת כניסה : הםעולה מקבלת מס שלם חיובי כלשהו
            //טענת יציאה : הפעולה מחזירה את העצרת של המספר

            
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return azeret(num - 1)*num;
            }
             
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(azeret(x));
        }
    }
}
