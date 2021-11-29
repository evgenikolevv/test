using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Box : Figure
    {
        protected int Diagonal { get; set; }


        public Box(string type,int diagonal, int width, int height) : base(type,width, height)
        {
            Diagonal = diagonal;
        }

        public override double Lice()
        {
            return Diagonal * Width * Height;
        }

        public override void Show()
        {
            Console.WriteLine("страни на " + type + " <" + Diagonal + "," + Width + "," + Height + ">");
            Console.WriteLine("Лице " + this.Lice());
        }
    }
}
