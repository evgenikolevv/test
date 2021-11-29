using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1_zadacha4
{
    class IAuto
    {
        public int Skorost { get; set; }
        public string Dvigatel { get; set; }
        public string Color { get; set; }

        public double calculateTime(double distance)
        {
           return (distance / this.Skorost) * 60; ;
        }

        public override string ToString()
        {
            return Skorost + " " + Dvigatel + " " + Color;
        }
    }


}
