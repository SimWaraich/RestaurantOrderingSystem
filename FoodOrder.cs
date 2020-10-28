using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWVerB
{
    class FoodOrder
    {
        public string OrderName { get; set; }
        public double VegOrders { get; set; }
        public double MeatOrders { get; set; }
        public double TotalPrice { get { return (MeatOrders * 31.99 + VegOrders * 23.99); } }
        public FoodOrder()
        {
            OrderName = "";
            VegOrders = 0;
            MeatOrders = 0;
        }
        public FoodOrder(string ordername, double veggie, double meat)
        {
            OrderName = ordername;
            VegOrders = veggie;
            MeatOrders = meat;
        }
        public override string ToString()
        {
            string outputStr = "";
            outputStr = OrderName + "," + VegOrders + "," + MeatOrders + "," + TotalPrice;
            return outputStr;
        }
    }
}
