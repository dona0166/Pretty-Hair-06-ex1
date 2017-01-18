using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary
{
   public class Order
    {
        // Unique key for the product, and then the amount of this product in the order
        Dictionary<ProductType, int> orderlines = new Dictionary<ProductType, int>();
        private string deliveryDate;
        private string orderDate;
        OrderRepository or = new OrderRepository();
        public long OrderId { get; set; }


        public Order(string dd, string od, Dictionary<ProductType, int> ol)
        {
            
            orderlines = ol;
            deliveryDate = dd;
            orderDate = od;
            this.OrderId = or.GeneratorResult;
        }

        public bool CheckQuantity()
        {
            bool cond = true;

            foreach(KeyValuePair<ProductType,int> p in orderlines)
            {
                if (p.Key.Amount < p.Value) {
                    cond = false;
                }
            }
            return cond;
        }

        public Dictionary<ProductType, int> GetOrderLines()
        {
            return orderlines;
        }

        public Order()
        {

        }
        public override string ToString()
        {

            string orderString = "order [deliverydate="+ this.deliveryDate +", orderdate="+this.orderDate+"]";
            return orderString;
        }

        
    }
}
