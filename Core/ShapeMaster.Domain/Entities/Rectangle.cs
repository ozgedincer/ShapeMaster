using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeMaster.Domain.Common;

namespace ShapeMaster.Domain.Entities
{
    internal class Rectangle : Shape
    {
        public decimal ASide { get; set; }
        public decimal BSide { get; set; }

        public decimal GetArea()
        {
            return ASide*BSide;
        }
    }
}
