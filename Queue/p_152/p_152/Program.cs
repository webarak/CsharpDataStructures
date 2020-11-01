using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures;

namespace p_152
{
    class Program
    {
        public static bool IsFound(int n, Queue<int> q)//הפעולה בודקת אם המספר קיים בתור
        {
            Queue<int> temp = new Queue<int>();
            bool found = false;
            while (!q.IsEmpty())
            {
                if (q.Head().Equals(n))
                    found = true;
                temp.Insert(q.Remove());
            }
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
            return found;
        }
        public static void NoMultiply(Queue<int> q)//t_3
        {
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                if (!IsFound(q.Head(), temp))
                    temp.Insert(q.Remove());
                else
                    q.Remove();
            }
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }

        }
        public static int numberofevarim(Queue<string> qs)//פעולה המחזירה את מספר האיברים בתור
        {
            string str = qs.Head();
            int counter = 1;
            qs.Insert(qs.Remove());
            while (qs.Head() != str)
            {
                counter++;
                qs.Insert(qs.Remove());
            }

            return counter;
        }
        public static int numberofevarim(Queue<int> qs)//פעולה המחזירה את מספר האיברים בתור
        {
            int num = qs.Head();
            int counter = 1;
            qs.Insert(qs.Remove());
            while (qs.Head() != num)
            {
                counter++;
                qs.Insert(qs.Remove());
            }

            return counter;
        }
        public static bool IsGuessTrue(int n, Queue<string> qs)//תרגיל 4
        {
            bool yes = false;
            for (int i = 1; i <= n; i++)
            {
                if (qs.Head() == "gold" && i == n)
                {
                    yes = true;
                }
                qs.Insert(qs.Remove());
            }
            int num = numberofevarim(qs);
            for (int i = n; i < num; i++)
            {
                qs.Insert(qs.Remove());
            }
            return yes;
        }
        public static int minumber(Queue<int> q)//פעולה המקבלת תור ומחזירה את המספר המינימלי בו
        {
            int minvalue = int.MaxValue;
            Queue<int> q2 = new Queue<int>();
            int num = numberofevarim(q);
            for (int i = 0; i < num; i++)
            {
                while (!q.IsEmpty())
                {
                    if (q.Head() < minvalue)
                    {
                        minvalue = q.Head();
                    }
                    if (!q.IsEmpty())
                        q2.Insert(q.Remove());

                }
            }
            while (!q2.IsEmpty())
            {
                q.Insert(q2.Remove());
            }
            return minvalue;
        }
        public static Stack<int> UpOrder(Queue<int> q)//t_5
        {
            Stack<int> s = new Stack<int>();
            Queue<int> q2 = new Queue<int>();
            while (!q.IsEmpty())
            {
                int num = minumber(q);
                while (!q.IsEmpty())
                {
                    if (q.Head() != num)
                    {
                        q2.Insert(q.Remove());
                    }
                    else
                    {
                        s.Push(q.Remove());
                    }
                }
                while (!q2.IsEmpty())
                {
                    q.Insert(q2.Remove());
                }
            }
            return s;
        }


        public static void jobs_enough(Queue<Job> qj, int time)//t_6
        {
            Queue<Job> qj2 = new Queue<Job>();
            while (time >= 0 && !qj.IsEmpty())
            {
                time -= qj.Head().Get_Time_Job();
                if (time >= 0)
                {
                    qj2.Insert(qj.Remove());
                }
            }
            Console.WriteLine(qj2.ToString());
            while (!qj.IsEmpty())
            {
                qj2.Insert(qj.Remove());
            }
            while (!qj2.IsEmpty())
            {
                qj.Insert(qj2.Remove());
            }
        }

        public static void two_tours(Queue<string> open, Queue<string> close)//t_7
        {

            int numofopen = numberofevarim(open);
            int numofclose = numberofevarim(close);
            Queue<string> temp = new Queue<string>();
            if (numofopen>numofclose)
            {
                while(!close.IsEmpty())
                {
                    temp.Insert(open.Remove());
                    temp.Insert(close.Remove());
                }
                while(!open.IsEmpty())
                {
                    temp.Insert(open.Remove());
                }
            }
            else if (numofopen < numofclose)
            {
                while (!open.IsEmpty())
                {
                    temp.Insert(open.Remove());
                    temp.Insert(close.Remove());
                }
                while (!close.IsEmpty())
                {
                    temp.Insert(close.Remove());
                }
            }
            while (!temp.IsEmpty())
            {
                open.Insert(temp.Remove());
            }
        }

        public static void uporederqueues(Queue<int> q1, Queue<int> q2)//t_8
        {
            Queue<int> temp = new Queue<int>();
            while (!q1.IsEmpty() && !q2.IsEmpty())
            {
                if (q1.Head()>q2.Head())
                {
                    temp.Insert(q2.Remove());
                }
                else if (q1.Head() < q2.Head())
                {
                    temp.Insert(q1.Remove());
                }
                else
                {
                    temp.Insert(q2.Remove());
                    temp.Insert(q1.Remove());
                }
            }
            while (!q1.IsEmpty())
            {
                temp.Insert(q1.Remove());
            }
            while (!q2.IsEmpty())
            {
                temp.Insert(q2.Remove());
            }
            while (!temp.IsEmpty())
            {
                q1.Insert(temp.Remove());
            }
        }
        static void Main(string[] args)
        {
            //Queue<int> q = new Queue<int>();
            //q.Insert(1);
            //q.Insert(3);
            //q.Insert(5);
            //q.Insert(7);
            //q.Insert(9);
            //q.Insert(11);
            //q.Insert(13);
            //q.Insert(15);
            //q.Insert(17);
            //q.Insert(19);

            //Queue<int> q2 = new Queue<int>();
            //q2.Insert(2);
            //q2.Insert(4);
            //q2.Insert(6);
            //q2.Insert(8);
            //q2.Insert(10);
            //q2.Insert(12);
            //q2.Insert(14);
            //q2.Insert(16);
            //q2.Insert(18);
            //q2.Insert(20);
            ////Console.WriteLine(q.ToString());
            ////NoMultiply(q);
            ////Console.WriteLine(q.ToString());
            //uporederqueues(q, q2);
            //Console.WriteLine(q.ToString());

            //Queue<string> qs = new Queue<string>();
            //qs.Insert("a");
            //qs.Insert("b");
            //qs.Insert("c");
            //qs.Insert("gold");
            //qs.Insert("d");
            //qs.Insert("e");
            //qs.Insert("f");
            //qs.Insert("g");
            //qs.Insert("t");
            //qs.Insert("h");
            //qs.Insert("r");
            //qs.Insert("v");
            //qs.Insert("u");


            //Queue<string> qs2 = new Queue<string>();
            //qs2.Insert("1");
            //qs2.Insert("2");
            //qs2.Insert("3");
            //qs2.Insert("4");
            //qs2.Insert("5");
            //qs2.Insert("6");
            //qs2.Insert("7");
            //qs2.Insert("8");
            //qs2.Insert("9");
            //qs2.Insert("10");
            //qs2.Insert("11");
            ////Console.WriteLine(IsGuessTrue(4,qs));
            ////Console.WriteLine(qs.ToString());
            ////Console.WriteLine();
            ////Console.WriteLine(UpOrder(q).ToString());
            //two_tours(qs, qs2);
            //Console.WriteLine(qs.ToString());

            //Queue<Job> JobsQueue = new Queue<Job>();
            //JobsQueue.Insert(new Job("012", 12));
            //JobsQueue.Insert(new Job("123", 23));
            //JobsQueue.Insert(new Job("456", 34));
            //JobsQueue.Insert(new Job("789", 45));
            //JobsQueue.Insert(new Job("147", 46));
            //JobsQueue.Insert(new Job("258", 56));
            //JobsQueue.Insert(new Job("369", 67));
            //JobsQueue.Insert(new Job("159", 78));
            //JobsQueue.Insert(new Job("357", 89));
            //JobsQueue.Insert(new Job("954", 90));
            //jobs_enough(JobsQueue, 150);



        }
    }
}
