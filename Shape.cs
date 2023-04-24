using geometric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    internal class Shape
    {
        private string color;
        private bool filled;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }
        public Shape()
        {
            color = "green";
            filled = true;
        }
        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public override String ToString()
        {
            return $"A Shape with color of {color} and {Filled}";
        }
    }
    class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }
        public override String ToString()
        {

            return $"A Circle with radius = {radius},which is a subclass of {base.ToString()}";

        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;
        public double Width { get { return width; } set {  width = value; } }
        public double Height { get { return height; } set { height = value; } }
        public Rectangle()
        {
            width = 1.0;
            height = 1.0;
        }
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;            
        }
        public Rectangle(double width, double height,string color, bool filled):base(color, filled)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return (width + height) * 2;
        }
        public override String ToString() 
        {
            return $"A Rectangle width= {width} and height= {height}, which is a subclass of {base.ToString()}";
        }
    }
    
}

