using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeMaster.Domain.Common;

namespace ShapeMaster.Domain.Entities
{
    internal class Square: Shape
    {
        public decimal OneSide { get; set; }

        public Square()
        {
            Type = "Square";
        }
        public override decimal GetArea()
        {
            return OneSide *OneSide ;
        }
    }
}
