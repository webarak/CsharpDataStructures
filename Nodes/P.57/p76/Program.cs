using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p76
{
    class Program
    {
        public static IntNode BuildIntList(int numbeelements)//בונה רשימה
        {
            Random R = new Random();
            IntNode first = new IntNode(R.Next(1, 11));
            IntNode P;
            for (int i = 0; i < numbeelements - 1; i++)
            {
                P = new IntNode(R.Next(10, 100));
                P.SetNext(first);
                first = P;
            }
            return first;
        }

        public static int numberofrezef(int num, IntNode n)//תרגיל 2
        {
            int counter = 0;
            IntNode i = n;
            IntNode bl = null;
            while (i.HasNext() != false)
            {
                if (i.GetNext().HasNext() == false)
                {
                    bl = i;
                }
                if (i.GetValue() == num && i.GetNext().GetValue() != num)
                {
                    counter++;
                }
                i = i.GetNext();

            }
            if (bl.GetValue() != num && bl.GetNext().GetValue() == num)
            {
                counter++;
            }

            return counter;

        }

        public static void between(IntNode n, int num1, int num2)//תרגיל 3
        {
            IntNode j = n;
            for (int i = 0; i <= num1; i++)
            {
                j = j.GetNext();
            }
            for (int i = num1; i < num2 - 1; i++)

            {
                Console.Write(j.GetValue());
                j = j.GetNext();
            }
        }

        public static string oddevensame(IntNode n)//תרגיל 4
        {
            int countodd = 0;
            int counteven = 0;
            IntNode i = n;
            IntNode bl = null;
            while (i.HasNext() != false)
            {
                if (i.GetNext().HasNext() == false)
                {
                    bl = i;
                }
                if (i.GetValue() % 2 == 0)
                {
                    counteven++;
                }
                else
                {
                    countodd++;
                }
                i = i.GetNext();

            }
            if (bl.GetNext().GetValue() % 2 == 0)
            {
                counteven++;
            }
            else
            {
                countodd++;
            }

            if (countodd > counteven)
            {
                return "e";
            }
            else if (countodd < counteven)
            {
                return "z";
            }
            else
            {
                return "s";
            }
        }

        public static IntNode removenode(IntNode n, int num)//תרגיל 5
        {
            IntNode i = n;

            while (i.GetNext().HasNext())
            {

                if (i.GetNext().GetValue() == num)
                {
                    i.SetNext(i.GetNext().GetNext());
                }
                else
                {
                    i = i.GetNext();
                }
            }

            if (i.GetNext().GetValue() == num)
            {
                i.SetNext(null);
            }

            if (n.GetValue() == num)
            {
                n = n.GetNext();
            }

            return n;
        }


        public static bool isappear(IntNode n, int num)//בודק אם המספר נמצא ברשימה
        {
            IntNode i = n;
            while (i!=null)
            {
                if (i.GetValue() == num)
                {
                    return true;
                }
                i = i.GetNext();

            }
            return false;
        }
        public static IntNode noduoble(IntNode n)//תרגיל 6
        {
            IntNode i = n.GetNext();
            IntNode newn = new IntNode(n.GetValue());
            IntNode a = newn;
            while (i != null)
            {
                Console.WriteLine(i.GetValue());
                if (!isappear(newn, i.GetValue()))
                {
                    a.SetNext(new IntNode(i.GetValue()));
                    a = a.GetNext();
                }
                i = i.GetNext();
            }
            return newn;
            
        }
        public static IntNode T6(IntNode n)//תרגיל 6
        {
            IntNode p = n;
            IntNode first = n;
            IntNode a = n;
            while (p != null)
            {
                while (a != null)
                {
                    if (!a.HasNext())
                        break;

                    if (a.GetNext().GetValue() == p.GetValue() && a.GetNext() != p)
                        a.SetNext(a.GetNext().GetNext());
                    else
                        a = a.GetNext();
                }

                a = n;
                p = p.GetNext();
            }

            return first;
        }


        //public static IntNode newnode()
        //{
        //    IntNode n = BuildIntList(50);

        //    IntNode i = n;
        //    IntNode newn = null;
        //    while (i != null)

        //}
        static void Main(string[] args)
        {
            IntNode n = new IntNode(4, new IntNode(9, new IntNode(2, new IntNode(4, new IntNode(4, new IntNode(4, new IntNode(9, new IntNode(4, null))))))));
            Console.WriteLine(n.ToString());

            //Console.WriteLine(numberofrezef(4, n));
            //between(n, 2, 7);
            //Console.WriteLine(oddevensame(n));
            //IntNode i = removenode(n,4);
            //Console.WriteLine(i.ToString());
            Console.WriteLine(T6(n));
        }
    }
}

