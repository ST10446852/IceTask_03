using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask_03
{
    class Shape
    {
        string Name { get; }

        public Shape(string name)
        {
            Name = name;
        }

        public virtual void CalculateArea()
        {
            Console.WriteLine("Method will be overridden");
        }
    }
}
