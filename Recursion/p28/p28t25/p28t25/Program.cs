using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p28t25
{
    class Program
    {
        public static void mehalkim(int num, int dev)
        {
            //טענת כניסה : הפעולה מקבלת מספר ומחלק
            //טענת יציאה : הפעולה מדפיסה את מחלקי המספר
            if (dev <= num)
            {
                if (num % dev == 0)
                {
                    Console.WriteLine(dev);
                    mehalkim(num, dev + 1);
                }
                else
                {
                    mehalkim(num, dev + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            mehalkim(9,1);
        }
    }
}
