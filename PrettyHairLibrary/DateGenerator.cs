using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary
{
    public class DateGenerator : IKeyGenerator
    {
        public long result;
        public long NextKey()
        {

            result = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
            Console.WriteLine("The next id is " + result);
            Console.ReadKey();
            return result;
        }
    }
}
