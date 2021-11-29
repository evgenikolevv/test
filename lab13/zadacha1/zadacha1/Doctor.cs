using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Doctor : Profession
    {
        public string AmbolatorenList { get; set; }
        public string Recepta { get; set; }

        public override string ToString()
        {
            return "Doctor: " + " Field: " + Field + " Specialty: " + Specialty
                + " Degree: " + Degree + " Stavka: " + Stavka + " Ambolatoren List: " + AmbolatorenList + " Recepta: " + Recepta;
        }
    }
}
