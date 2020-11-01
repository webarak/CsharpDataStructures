using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures;

namespace p._121
{
    class Program
    {
        public static bool memuian(Stack<int> s)//tr_5
        {
            Stack<int> temp = new Stack<int>();
            temp.Push(-1);
            while (!s.IsEmpty())
            {
                if (temp.Top() > s.Top())
                    return false;
                temp.Push(s.Pop());
            }
            while (!temp.IsEmpty())
            {
                s.Push(temp.Pop());
            }
            s.Pop();
            return true;
        }

        public static Stack<int> circle(Stack<int> s)//tr_6
        {
            Stack<int> temp = new Stack<int>();
            Stack<int> temppppppp = new Stack<int>();
            while (!s.IsEmpty())
            {
                temp.Push(s.Pop());
            }
            while (!temp.IsEmpty())
            {
                temppppppp.Push(temp.Pop());
            }
            while(!temppppppp.IsEmpty())
            {
                s.Push(temppppppp.Pop());
            }
            return s;
        }
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(9);
            s.Push(8);
            s.Push(7);
            s.Push(6);
            s.Push(5);
            s.Push(4);
            s.Push(3);
            s.Push(2);
            s.Push(1);
            Console.WriteLine(s.ToString());
            Console.WriteLine(memuian(s));
            Stack<int> s2 = circle(s);
            Console.WriteLine(s2.ToString());
            
        }
    }
}
