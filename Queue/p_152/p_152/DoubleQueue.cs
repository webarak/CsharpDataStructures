using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures;

namespace p_152
{
    class DoubleQueue
    {
        private Queue<int> fastQueue;
        private Queue<int> slowQueue;
        private static int numberoffast = 0;

        
        public DoubleQueue()
        {
            this.fastQueue = new Queue<int>();
            this.slowQueue = new Queue<int>();
        }

        public DoubleQueue(Queue<int> f, Queue<int> s)
        {
            this.fastQueue = f;
            this.slowQueue = s;
        }

        public Queue<int> Get_FastQueue()
        {
            return this.fastQueue;
        }
        public Queue<int> Get_SlowQueue()
        {
            return this.slowQueue;
        }

        public void Set_FAST(Queue<int> f)
        {
            this.fastQueue = f;
        }
        public void Set_Slow(Queue<int> s)
        {
            this.slowQueue = s;
        }

        public Queue<int> Get_Queue(int act)
        {
            if (act == 0)
                return this.slowQueue;
            else
                return this.fastQueue;
        }

        public void Add_Costumer(int num, int act)
        {
            if (act == 1)
                this.slowQueue.Insert(num);
            else
                this.fastQueue.Insert(num);
        }

        public int Costumer_Out()
        {
            if (numberoffast%5==0)
            {
                return this.slowQueue.Remove();
            }
            else
            {
                DoubleQueue.numberoffast++;
                return this.fastQueue.Remove();
            }
        }
    }
}
