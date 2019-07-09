using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.Entities.Enum;

namespace Abstract.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        protected Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
        
    }
}
