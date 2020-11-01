using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p27t18
{
    class Program
    {
        public static bool isrishoni(int num, int a)
        {
            //טענת כניסה : הפעולה מקבלת מספר שלם ואת המספר 2
            //טענת יציאה : האם המספר ראשוני או לא

            if (num % a == 0)
            {
                return false;
            }
            else if (a == num / 2)
            {
                return true;
            }
            else
            {
                return isrishoni(num, a + 1);
            }


        }
        public static bool notrishoni(int []a, int index)
        {
            //טענת כניסה : הפעולה מקבלת מערך מספרים ואינדקס התחלתי
            //טענת יציאה : הפעולה מחזירה אמת אם המערך ללא מספרים ראשוניים ושקר אם כן
            if (index == -1)
            {
                return true;
            }
            else
            {
                if (isrishoni(a[index],2))
                {
                    return false;
                }
                else
                {
                    return notrishoni(a, index - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5};
            Console.WriteLine(notrishoni(a,a.Length-1));
        }
    }
}
