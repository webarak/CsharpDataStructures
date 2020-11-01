using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAKI
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock suply = new Stock(new Delivery());
            suply.SET_DELIVERY(new Delivery(100, 15));
            suply.SET_DELIVERY(new Delivery(73, 30));
            Console.WriteLine(suply.ToString());
            Console.WriteLine(suply.PriceOfOrder(45) / Stock.GET_PRECENT());
            Console.WriteLine(suply.ToString());
        }
    }
}
