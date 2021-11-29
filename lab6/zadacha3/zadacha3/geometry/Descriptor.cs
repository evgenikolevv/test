using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    abstract class Descriptor
    {
        public abstract string Name { get; set; }

        public virtual string Describe() 
        {
            if (Name.Equals("Square"))
            {
                return "A quandrilateral is a geometric figure that has four sides and four angles.\n A square is a quandrilateral that has four equal sides and four right angles.";
            }
            else if(Name.Equals("Rectangle"))
            {
                return "A quandrilateral is a geometric figure.\n A rectangle is a quandrilateral that has adjanced perpendicular sides. This implies that its four angles are right.";

            }
            return "";
        }
    }
}
