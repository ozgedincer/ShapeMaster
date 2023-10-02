using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{

    internal class Circle : Shape
    {

        public decimal r { get; set; }
        public decimal Pi { get; } = 3.14159M;

        public override decimal GetArea()
        {
            return Pi * r * r;
        }

    }

}
