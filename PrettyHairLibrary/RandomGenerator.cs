using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary
{
    public class RandomGenerator : IKeyGenerator
    {
        Random r = new Random();
        long result;
        public long NextKey()
        {   
            result = r.Next(1000);
            Console.WriteLine("The next id is " + result);
            Console.ReadKey();
            return result;
        }
    }
}
