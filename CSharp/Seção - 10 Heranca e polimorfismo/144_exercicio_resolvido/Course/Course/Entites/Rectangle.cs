using Course.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entites
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width,double height,Color color):base(color)
        {
            Height = height;
            Width  = width;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
