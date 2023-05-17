using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise009
{
    public class Dalmatian
    {
        public string name { get; set; }
        public int spots { get; set; }

        public Dalmatian(string name, int spots)
        {
            this.name = name;
            this.spots = spots;
        }

    }
}