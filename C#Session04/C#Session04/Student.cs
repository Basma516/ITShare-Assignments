using System;
using System.Collections.Generic;
using System.Text;

namespace C_Session04
{
    public class Student : Person
    {
        private string Program;
        private int Year;
        private double Fee;
        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }
        public string GetProgram()
        {
            return Program;
        }
        public void SetProgram(string program)
        {
            this.Program = program;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int year)
        {
            this.Year = year;
        }
        public double GetFee()
        {
            return Fee;
        }
            
        public void SetFee(double fee)
        {
            this.Fee = fee;
        }
        public override string toString()
        {
            return "Student: subclass of " + base.toString() + " program=" + Program + " year=" + Year + " fee=" + Fee;
        }
    }
}
