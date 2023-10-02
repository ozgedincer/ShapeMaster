using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeMaster.Domain.Abstract;

namespace ShapeMaster.Domain.Common
{
    internal abstract class Shape : ISaveable
    {

        public string Type { get; set; }
        public abstract decimal GetArea();

        public string GetInfo()
        {
            return $"{Type} AREA: {GetArea()}";
        }
    }
}
