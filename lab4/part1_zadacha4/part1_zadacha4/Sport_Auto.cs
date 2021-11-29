using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1_zadacha4
{
    class Sport_Auto : IAuto
    {
        public bool Nos { get; set; }
        public bool Spoiler { get; set; }

        public override string ToString()
        {
            return Skorost + " " + Dvigatel + " " + Color + " Nos: " + Nos + " Spoiler: " + Spoiler;
        }
    }
}
