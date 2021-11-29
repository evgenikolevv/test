using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Teacher : Profession
    {
        public string Predmet { get; set; }
        public string Klas { get; set; }

        public override string ToString()
        {
            return "Teacher: " + " Field: " + Field + " Specialty: " + Specialty 
                + " Degree: " + Degree + " Stavka: " + Stavka + " Predmet: " + Predmet + " Klas: " + Klas;
        }
    }
}
