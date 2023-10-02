using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Common
{
    internal abstract class Shape
    {
        //public decimal FindArea()
        //{

        //}

        public string Type { get; set; }
        public abstract decimal GetArea();

        public string GetInfos()
        {
            return $"{Type} AREA: {GetArea()}";
        }
    }
}
