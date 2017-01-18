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
        long result;
        public long NextKey()
        {
            result = neworder.GetOrderList().Count() + 1;
            Console.WriteLine("The next id is " + result);
            Console.ReadKey();
            return result;
        }
    }
}
