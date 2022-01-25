using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid2022
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }
        public Rectangle(double width,double height)
        {
            this.Width = width; 
            this.Height = height; 
        }

        public double GetArea()
        {
            return this.Width * this.Height;    
        }
    }
}
