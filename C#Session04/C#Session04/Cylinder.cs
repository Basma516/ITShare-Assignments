using System;
using System.Collections.Generic;
using System.Text;

namespace C_Session04
{
    public class Cylinder : Circle
    {
        private double height;
        public Cylinder()
        {
            height = 1.0;
        }
        public Cylinder(double radius) : base(radius)
        {
            height = 1.0;
        }
        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }
        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetVolume()
        {
            return GetArea() * height;
        }
        public override string toString()
        {
            return "Cylinder: subclass of " + base.toString() + " height=" + height;
        }
    }
}
