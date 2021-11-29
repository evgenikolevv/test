using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3.Test_abstract
{
    class Rectangle : Descriptor
    {
        int Height { get; set; }
        int Width { get; set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override string Name { get => "Rectangle"; set => Name = "Rectangle"; }
    }
}
