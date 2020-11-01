using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p28t31
{
    class Program
    {
        public static void evenindex(int [] arr , int index)
        {
            //טענת כניסה : הפעולה מקבלת מערך מספרים ואת האינדקס הראשון במערך, כלומר 0
            //טענת יציאה : הפעולה מדפיסה את האיברים שהמציינים שלהם זוגיים
            if (index < arr.Length)
            {
                if (index % 2 == 0)
                {
                    Console.WriteLine(arr[index]);
                    evenindex(arr, index + 2);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            evenindex(arr, 0);
        }
    }
}
