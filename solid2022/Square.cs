using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid2022
{
    internal class Square : Rectangle
    {
        public Square(double size)
        {
            this.Width = size;
            this.Height = size;
        }
    }
}
