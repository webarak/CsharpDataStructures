using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures;

namespace p._130
{
    class Program
    {
        public static int numofnum(Stack<int> s)
        {
            int counter = 0;
            Stack<int> temp = new Stack<int>();
            while (!s.IsEmpty())
            {
                counter++;
                temp.Push(s.Pop());
            }
            while(!temp.IsEmpty())
            {
                s.Push(temp.Pop());
            }
            return counter;
        }
        public static void ola_yored(Stack<int> s)//tr_11
        {
            Stack<int> ola = new Stack<int>();
            ola.Push(int.MinValue);
            Stack<int> yored = new Stack<int>();
            yored.Push(int.MaxValue);
            while (s.Top() > ola.Top())
            {
                ola.Push(s.Pop());
            }
            while (!s.IsEmpty())
            {
                yored.Push(s.Pop());
            }
            if (numofnum(yored) > numofnum(ola)-1)
            {
                Console.WriteLine("there are more numbers in ole numbers");
            }
            else if (numofnum(yored) < numofnum(ola)-1)
            {
                Console.WriteLine("there are more numbers in down numbers");
            }
            else
            {
                Console.WriteLine("thare is the same number of numbers in the two rezefs");
            }
            while(!yored.IsEmpty())
            {
                s.Push(yored.Pop());
            }
            s.Pop();
            while (!ola.IsEmpty())
            {
                s.Push(ola.Pop());
            }
            s.Pop();

        }

        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(4);
            s.Push(3);
            s.Push(2);
            s.Push(1);
            ola_yored(s);
            Console.WriteLine(s.ToString());
        }
    }
}
