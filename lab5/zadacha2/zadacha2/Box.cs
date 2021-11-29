using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Box : Idimensions
    {
        public float LengthInches { get; set; }
        public float WidthInches { get; set; }

        public Box (float length, float width)
        {
            LengthInches = length;
            WidthInches = width;
        }

        public float Length()
        {
            return this.LengthInches;
        }

        public float Width()
        {
            return this.WidthInches;
        }
    }
}
