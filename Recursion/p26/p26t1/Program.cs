using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p26t1
{
    class Program
    {
        public static int SumTill(int num)
        {
            //הפעולה מקבלת מספר שלם כלשהו
            //הפעולה מחזירה את סכום הספרות עד המספר
            if (num==0)
                return 0;
            else
                return SumTill(num-1)+num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumTill(4));
        }
    }
}
