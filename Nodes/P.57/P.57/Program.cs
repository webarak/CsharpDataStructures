using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P._57
{
    class Program
    {
        static void Main(string[] args)
        {
            IntNode n1 = new IntNode(50);
            IntNode n2 = new IntNode(30);
            IntNode n3 = new IntNode(10);
            IntNode n4 = new IntNode(20);
            IntNode n5 = new IntNode(40);
            n1.SetNext(n2);
            n2.SetNext(n3);
            n3.SetNext(n4);
            n4.SetNext(n5);
            IntNode numbers = n1;
            IntNode p = numbers;
            while (p != null)
            {
                p.SetValue(p.GetValue() + 1);
                p = p.GetNext();
            }
            Console.WriteLine(n1.ToString());

            

        }
    }
}
