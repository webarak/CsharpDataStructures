using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAKI
{
    class Delivery
    {
        private double price;
        private int amount;

        public Delivery()
        {
            price = 0;
            amount = 0;
        }

        public Delivery(double p, int a)
        {
            price = p;
            amount = a;
        }

        public double GET_PRICE()
        {
            return this.price;
        }

        public int GET_AMOUNT()
        {
            return this.amount;
        }

        public void SET_PRICE(double p)
        {
            this.price = p;
        }

        public void SET_AMOUNT(int a)
        {
            this.amount = a;
        }

        public override string ToString()
        {
            return "amount: " + this.amount + "\nprice: " + this.price;
        }


    }
}
