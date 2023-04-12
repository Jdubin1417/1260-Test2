using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Test2Review
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle()
        {
            Name = "Triangle";
            Base = 5;
            Height = 3;
        }

        public Triangle(double triBase, double height)
        {
            Name = "Triangle";
            Base = triBase;
            Height = height;
        }

        public override double CalcArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
