using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary
{
    public class IncrementalGenerator : IKeyGenerator
    {
        OrderRepository neworder = new OrderRepository();
        public long NextKey()
        {
            return neworder.GetOrderList().Count() + 1;
        }
    }
}
