using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary
{
    public class DateGenerator : IKeyGenerator
    {
        public long NextKey()
        {
            return long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
        }
    }
}
