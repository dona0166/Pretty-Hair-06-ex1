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
        public long NextKey()
        {
            return r.Next(1000);
        }
    }
}
