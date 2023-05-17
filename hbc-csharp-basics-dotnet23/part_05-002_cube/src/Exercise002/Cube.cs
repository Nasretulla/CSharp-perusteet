using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise002
{
    public class Cube
    {
        public int edgeLength;
        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;

        }
        public int Volume()
        {
            return edgeLength * edgeLength * edgeLength;
        }

        public override string ToString()
        {
            int volume = Volume();

            return "The length of the edge is " + this.edgeLength + " and the volume " + volume;

        }


    }
}