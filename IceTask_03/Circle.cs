using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IceTask_03
{
    class Circle : Shape , ICalculateArea
    {
        double radius { get; }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Round(Math.Pow(radius, 2)));
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius: {radius}, Area: {CalculateArea()}");
        }
    }
}
