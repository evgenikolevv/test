using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1_zadacha4
{
    class Track : IAuto
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Potencial { get; set; }

        public override string ToString()
        {
            return Skorost + " " + Dvigatel + " " + Color + " Weight: " + Weight + " Height: " + Height + " Width: " + Width + " Potencial: " + Potencial;
        }
    }
}
