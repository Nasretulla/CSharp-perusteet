using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise010
{
    public class Gauge
    {
        public int value { get; set; }

        public Gauge()
        {

        }

        public void Increase()
        {
            if (this.value < 5)
            {
                this.value++;

            }

        }
        public void Decrease()
        {
            if (this.value > 0)
            {
                this.value--;

            }
        }
        public bool Full()
        {
            if (this.value == 5)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}