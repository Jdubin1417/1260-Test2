using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Test2Review
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public abstract double CalcArea();
        public string FormatName()
        {
            return $"Name: {Name}";
        }
    }
}
