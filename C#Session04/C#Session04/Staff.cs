using System;
using System.Collections.Generic;
using System.Text;

namespace C_Session04
{
    public class Staff : Person
    {
        private string School;
        private double Pay;
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.School = school;
            this.Pay = pay;
        }
        public string GetSchool()
        {
            return School;
        }
        public void SetSchool(string school)
        {
            this.School = school;
        }
            
        public double GetPay()
        {
            return Pay;
        }
        public void SetPay(double pay)
        {
            this.Pay = pay;
        }
        public override string toString()
        {
            return "Staff: subclass of " + base.toString() + " school=" + School + " pay=" + Pay;
        }
    }
}
