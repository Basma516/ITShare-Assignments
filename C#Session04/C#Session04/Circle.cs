using System;
using System.Collections.Generic;
using System.Text;

namespace C_Session04
{
    public class Circle
    {
        //4.1  An Introduction to OOP Inheritance by Example - The Circle and Cylinder Classes
        private double radius;
        private string Color;

        public Circle()
        {
            radius = 1.0;
            Color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
            this.Color = "red";
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.Color = color;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string color)
        {
            this.Color = color;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public virtual string toString()
        {
            return "Circle[radius=" + radius + ",color=" + Color + "]";
        }
    }
}
