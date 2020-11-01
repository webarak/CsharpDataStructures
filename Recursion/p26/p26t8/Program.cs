using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26t8
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
                    return isrishoni(num, a+1);
                }
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine(isrishoni(27,2));
        }
    }
}
