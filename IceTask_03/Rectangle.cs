using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IceTask_03
{
    class Rectangle : Shape
    {
        int Length { get; }
        int Width { get; } 

        public Rectangle (int lenght, int width) : base(name)
        {
            this.Width = width;
            this.Length = lenght;
        }
    }
}
