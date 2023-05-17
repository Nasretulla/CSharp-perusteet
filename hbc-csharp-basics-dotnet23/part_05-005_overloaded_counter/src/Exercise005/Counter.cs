using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise005
{
    public class Counter
    {

        public int startValue;
        public Counter(int startValue)
        {
            this.startValue = startValue;
            this.value = startValue;
        }

        public Counter()
        {
            this.startValue = 0;
        }

        public int value { get; set; }

        public void Increase()
        {
            this.value = this.value + 1;

        }

        public void Decrease()
        {
            this.value = this.value - 1;
        }

        public void Increase(int increaseBy)
        {
            if (increaseBy > 0)
            {
                this.value += increaseBy;

            }
            else
            {

            }

        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                this.value -= decreaseBy;
            }
            else
            {

            }
        }
    }
}