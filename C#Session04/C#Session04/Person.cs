using System;
using System.Collections.Generic;
using System.Text;

namespace C_Session04
{
    public class Person
    {
        private string Name;
        private string Address;
     
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string address)
        {
            this.Address = address;
        }
        public virtual  string toString()
        {
            return "Person[name=" + Name + ",address=" + Address + "]";
        }


    }
}
