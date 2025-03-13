using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IceTask_03
{
    class Rectangle : Shape, ICalculateArea
    {
        double Length { get; }
        double Width { get; }

        public Rectangle(string name, double width, double length) : base(name)
        {
            this.Width = width;
            this.Length = length;
        }
        public double CalculateArea()
        {
            return Width * Length;
        }

        public override void Display()
        {
            
            Console.WriteLine($"Width: {Width}, Height: {Length}, Area: {CalculateArea()}");
        }
    }
}
