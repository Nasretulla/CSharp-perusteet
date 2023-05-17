using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise012
{

    public class Multiplier
    {
        private int _multiplier;

        public Multiplier(int number)
        {
            _multiplier = number;
        }

        public int Multiply(int number)
        {
            int result = number * _multiplier;
            _multiplier = result;
            return result;
        }
    }
}