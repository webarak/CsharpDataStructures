using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p27t19
{
    class Program
    {
        public static bool isappearinarr(int[] a, int num, int i)
        {
            //טענת כניסה : הפעולה מקבלת מערך מספרים, אינדקס של איבר במערך ומספר
            //טענת יציאה: הפעולה מחזירה אמת אם המספר מופיע במערך ושקר אם לא
            if (i<0)
            {
                return false;
            }
            else
            {
                if (a[i]==num)
                {
                    return true;
                }
                else
                {
                    return isappearinarr(a, num, i - 1);
                }
            }
        }



        public static int[] mattoarr(int [,] a, int row)
        {
            //טענת כניסה : הפעולה מקבלת מטריצה ומספר שורה
            //טענת יציאה : הפעולה מחזירה מערך של השורה במטריצה
            int[] b = new int[a.GetLength(1)];
            
            for (int j = 0; j<a.GetLength(1); j++)
            {
                b[j] = a[row, j]; 
            }
            
            return b;
        }


        public static bool isappearinmatriza(int [,] mat, int num, int i)
        {
            
        }
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4, 5, 6, 7, 8 } , { 546, 45634, 545, 546, 56546, 4324,534,345 } };
            int[] b = mattoarr(a,0);
            for (int i = 0; i<b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
