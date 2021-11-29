using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Figure : Demo
    {
        protected int Width { get; set; }
        protected int Height { get; set; }

        public Figure(string Type, int width, int height)
        {
            Width = width;
            Height = height;
            type = Type;
        }

        public override double Lice()
        {
            return Width * Height;
        }

        public override void Show()
        {
            Console.WriteLine("страни на " + type + " <" + Width + "," + Height + ">");
            Console.WriteLine("Лице " + this.Lice());
        }
    }
}
