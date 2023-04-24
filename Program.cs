using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape("red",false);
            Console.WriteLine(shape);
            Circle circle = new Circle(5.6);
            Console.WriteLine(circle.GetArea());
            Rectangle rectangle = new Rectangle(6, 8);
            Console.WriteLine(rectangle.GetArea());
            Console.ReadLine();
        }
    }
}
