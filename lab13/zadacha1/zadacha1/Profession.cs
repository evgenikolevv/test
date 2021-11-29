using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Profession
    {
        public string Field { get; set; }
        public string Specialty { get; set; }
        public string Degree { get; set; }

        public int Stavka { get; set; }

        public int calculate(int hours)
        {
            return Stavka * hours;
        }
    }
}
