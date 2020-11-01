using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p27t17
{
    class Program
    {
        public static bool isole(int [] a, int index)
        {
            //טענת כניסה : הפעולה מקבלת מערך מספרים ואינדקס התחלתי 1
            //טענת יציאה : אמת אם המערך בסדר עולה ושקר אם לא
            if (index +1 ==  a.Length)
            {
                return true;
            }
            else
            {
                if (a[index]<a[index+1])
                {
                    return isole(a, index + 1);
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(isole(a,1));
        }
    }
}
