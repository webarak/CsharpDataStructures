using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures;

namespace p._94
{
    class Program
    {
        public static Node<int> place(Node<int> n, int num)//t_24
        {
            Node<int> p = n;
            while (p != null)
            {
                if (p.GetValue() == num)
                    return p;
                p = p.GetNext();
            }
            
            return null;
        }

        public static bool isrezef(Node<int> n, int num)//בודק אם יש רצף מספרים
        {
            Node<int> p = n;
            while (p.GetNext()!=null)
            {
                if (p.GetValue() == p.GetNext().GetValue() && p.GetValue() == num)
                    return true;
                p = p.GetNext();
            }
            return false;
        }

        public static bool isnumrezef(Node<int> lis, int num)//t_25
        {
            Node<int> p = lis;
            int count = 1;
            while (p.GetNext()!=null)
            {
                if (p.GetValue() == p.GetNext().GetValue()-1)
                {
                    count++;
                    if (count == num)
                        return true;
                }
                else
                    count = 1;
                p = p.GetNext();
                
            }
            return false;
        }

        public static Node<int> zogifirstThannot(Node<int> n)//t_26
        {
            Node<int> p = n;
            Node<int> sec = new Node<int>(0);
            Node<int> last = sec;

            while(p!=null)
            {
                if (p.GetValue() % 2 == 0)
                {
                    sec.SetNext(new Node<int>(p.GetValue()));
                    sec = sec.GetNext();
                }
                p = p.GetNext();
            }
            p = n;
            while (p != null)
            {
                if (p.GetValue() % 2 != 0)
                {
                    sec.SetNext(new Node<int>(p.GetValue()));
                    sec = sec.GetNext();
                }
                p = p.GetNext();

            }
            n = last;
            return n.GetNext();

        }

        //public static Node<int> deletrezef(Node<int> n)//t_27
        //{
        //    Node<int> p = n;
        //    Node<int> sec = new Node<int>(0);
        //    Node<int> last = sec;
        //    while (p!=null)
        //    {
        //        if (p.get)
        //    }
        //}

        public static int equi(Node<int> n)
        {
            Node<int> p = n;
            int counter = 0;
            bool yes = true;
            while (p.GetNext().GetNext().GetNext() != null)
            {
                while (p.GetValue() != -999 && p != null)
                {
                    if ((p.GetValue() < p.GetNext().GetValue() && p.GetNext().GetValue() > p.GetNext().GetNext().GetValue()) ||
                        (p.GetValue() > p.GetNext().GetValue() && p.GetNext().GetValue() < p.GetNext().GetNext().GetValue()))
                    {
                        yes = false;
                    }
                    p = p.GetNext();
                }
                p = p.GetNext();
                if (yes == true)
                    counter++;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            Node<int> n = new Node<int>(4, new Node<int> (3, new Node<int>(2, new Node<int>(5, new Node<int>(6,new Node<int>(7, new Node<int>(4)))))));
            Node<int> n4 = new Node<int>(4, new Node<int>(3, new Node<int>(2, new Node<int>(-999, new Node<int>(6, new Node<int>(7, new Node<int>(96)))))));
            Node<int> n2 = place(n, 9);
            //Console.WriteLine(n2.ToString());
            Console.WriteLine(isnumrezef(n,3));
            Node<int> n3 = zogifirstThannot(n);
            while (n3 != null)
            {
                Console.Write(n3.ToString() + "-->");
                n3 = n3.GetNext();
            }
            Console.WriteLine();
            Console.WriteLine(equi(n4));

        }
    }
}
