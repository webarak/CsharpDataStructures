using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures;

namespace NAKI
{
    class Stock
    {
        private Stack<Delivery> ST = new Stack<Delivery>();
        private static double precent = 1.2;

        public Stock()
        {
            this.ST = null;
        }

        public Stock(Delivery d)
        {
            this.ST.Push(d);
        }

        public double PriceOfOrder(int towels)//מחיר מכירה
        {
            double price = 0;
            int TowelsPerOrder = 0;
            bool wow = false;
            while (!wow)
            {
                if(towels<this.ST.Top().GET_AMOUNT())
                {
                    this.ST.Top().SET_AMOUNT(this.ST.Top().GET_AMOUNT() - towels);
                    price = this.ST.Top().GET_PRICE() * towels*Stock.precent;
                    wow = true;
                }
                else if(towels == this.ST.Top().GET_AMOUNT())
                {
                    price = this.ST.Top().GET_PRICE() * towels* Stock.precent;
                    this.ST.Pop();
                    wow = true;
                }
                else
                {
                    while (towels > 0)
                    {
                        if (towels >= this.ST.Top().GET_AMOUNT())
                        { 
                            TowelsPerOrder = this.ST.Top().GET_AMOUNT();
                            price += this.ST.Top().GET_PRICE() * this.ST.Top().GET_AMOUNT()* Stock.precent;
                            this.ST.Pop();
                            towels = towels - TowelsPerOrder;
                        }
                        else
                        {
                            this.ST.Top().SET_AMOUNT(this.ST.Top().GET_AMOUNT() - towels);
                            price += this.ST.Top().GET_PRICE() * towels* Stock.precent;
                            towels -=towels;
                        }
                    }
                    wow = true;
                }
            }

            return price;
        }
        


        public Delivery GET_DELIVERY()
        {
            return this.ST.Top();
        }

        public void SET_DELIVERY(Delivery d)
        {
            this.ST.Push(d);
        }

        public  override string ToString()
        {
            return this.ST.ToString();
        }

        public static double GET_PRECENT()
        {
            return Stock.precent;
        }

    }
}
