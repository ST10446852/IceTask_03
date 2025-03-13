using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask_03
{
    public abstract class Shape
    {
        string Name { get; }

        public Shape(string name)
        {
            this.Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Shape: " + Name);


        }
    }
}
