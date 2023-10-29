using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class sample
    {
        public string name1;
        public string address;
        public string GetInfo()
        {
            return String.Format("{0} is in city{1}", name1, " ", address);
        }
    }
}
