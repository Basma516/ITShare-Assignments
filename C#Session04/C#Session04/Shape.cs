using System;
using System.Collections.Generic;
using System.Text;

namespace C_Session04
{
    public abstract class Shape
    {
        protected string Color;
        protected bool Filled;
        public Shape()
        {
            Color = "red";
            Filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string color)
        {
            this.Color = color;
        }
        public bool IsFilled()
        {
            return Filled;
        }
        public void SetFilled(bool filled)
        {
            this.Filled = filled;
        }
        public abstract  double GetArea();
        public abstract double GetPerimeter();

        public virtual string toString()
        {
            return "Shape[color=" + Color + ",filled=" + Filled + "]";
        }
    }

    public class Rectangle : Shape
    {
        protected double Width;
        protected double Length;
        public Rectangle()
        {
            Width = 1.0;
            Length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }
        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.Width = width;
            this.Length = length;
        }
        public double GetWidth()
        {
            return Width;
        }
        public void SetWidth(double width)
        {
            if (width > 0)
            {
                this.Width = width;
            }
            else            
            {
                Console.WriteLine("Width must be positive.");
            }
        }
        public double GetLength()
        {
            return Length;
        }
        public void SetLength(double length)
        {
            if (length > 0)
            {
                this.Length = length;
            }
            else
            {
                Console.WriteLine("Length must be positive.");
            }
        }
        public override double GetArea()
        {
            return Width * Length;
        }
        public override double GetPerimeter()
        {
            return 2 * (Width + Length);
        }
        public override string toString()
        {
            return "Rectangle: subclass of " + base.toString() + " width=" + Width + " length=" + Length;
        }
    }

    public  class circle : Shape
    {
        protected double Radius;
        public circle()
        {
            Radius = 1.0;
        }
        public circle(double radius)
        {
            this.Radius = radius;
        }
        public circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.Radius = radius;
        }
        public double GetRadius()
        {
            return Radius;
        }
        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                this.Radius = radius;
            }
            else
            {
                Console.WriteLine("Radius must be positive.");
            }
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override string toString()
        {
            return "Circle: subclass of " + base.toString() + " radius=" + Radius;
        }
    }
}
