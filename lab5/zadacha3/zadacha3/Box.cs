using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Box : Idimensions, IEnglishDimensions, IMetricDimensions
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
            return LengthInches;
        }

        public float Width()
        {
            return WidthInches;
        }

        public float lengthInches()
        {
            return (float)(LengthInches * 0.393705);
        }

        public float widthInches()
        {
            return  (float)(WidthInches * 0.393705);
        }

        public float LengthCm()
        {
            return (float)(LengthInches * 2.54);
        }

        public float WidthCm()
        {
            return (float)(WidthInches * 2.54);
        }

        public override string ToString()
        {
            return "length :" + LengthInches + " width: " + WidthInches;
        }
    }
}
