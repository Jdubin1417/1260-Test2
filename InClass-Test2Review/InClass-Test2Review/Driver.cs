using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Test2Review
{
    public class Driver
    {
        public static void Main()
        {
            Rectangle r = new Rectangle(3, 4);
            Console.WriteLine($"The area of the rectangle ({r.FormatName()}) is {r.CalcArea()}");

            Shape myShape = new Rectangle(2.4, 5.8);

            List<Shape> myShapes = new List<Shape>();
            myShapes.Add(new Rectangle(6, 7.2));
            myShapes.Add(new Rectangle(5.2, 8.3));
            myShapes.Add(new Triangle(5, 8.6));
            myShapes.Add(new Triangle(3.4, 2));
            myShapes.Add(new Rectangle(4, 5));

            foreach(Shape s in myShapes)
            {
                if(s is Rectangle)
                {
                    Console.WriteLine("This shape is a rectangle");
                }
                else if(s is Triangle)
                {
                    Console.WriteLine("This shape is a triangle");
                }
                else
                {
                    Console.WriteLine("This is some other shape");
                }

                Console.WriteLine("The shape's area is " + s.CalcArea());
            }

            Console.WriteLine(Add(4.5, 2.3));
            Console.WriteLine(Add("4", "a"));

            ExceptionExample();
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        /*
        public static double Add(int x, int y)
        {
            return (double)x + (double)y;
        }
        */

        public static string Add(string x, string y)
        {
            return x + y;
        }

        public static double Add(int x, double y, int z)
        {
            return x + y + z;
        }

        public static void ExceptionExample()
        {
            try
            {
                int x = int.Parse("a");
                Console.WriteLine(x);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("------");
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
