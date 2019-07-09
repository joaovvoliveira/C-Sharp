using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.Entities.Enum;

namespace Abstract.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        double pi = 3.14;

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return pi * (Radius * Radius);
        }
    }
}
