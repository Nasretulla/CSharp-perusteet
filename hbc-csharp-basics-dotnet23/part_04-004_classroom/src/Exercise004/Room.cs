using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise004
{
    public class Room
    {
        private string code;
        private int seats;

        public Room(string classCode, int numberOfseats)
        {

            code = classCode;
            seats = numberOfseats;

        }
    }
}