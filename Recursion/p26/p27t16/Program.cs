using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p27t16
{
    class Program
    {
        public static int placeofnum(int []a, int num, int index)
        {
            //טענת כניסה : הפעולה מקבלת מערך מספרים, מספר שלם וכמות האיברים במערך
            //טענת יציאה : מיקום המספר במערך
            if (index ==-1)
            {
                return -1;
            }
            else
            {
                if (a[index] == num)
                {
                    return index;
                }
                else
                {
                    return placeofnum(a, num, index - 1);
                }

            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine(placeofnum(a,4,a.Length-1));
        }
    }
}
