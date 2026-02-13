using System;
using System.Collections.Generic;
using System.Text;

namespace C_Session04
{
    public abstract class Animal
    {
        private string name;
        public string Name { get; set ; }
        
        public Animal(string name)
        {
            this.Name = name;
        }
        public abstract void Greets();

    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public override void Greets()
        {
            Console.WriteLine("Woof");
        }
        public virtual void Greets(Dog another)
        {
            Console.WriteLine("Woooof");
        }
    }
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override void Greets()
        {
            Console.WriteLine("Meow");
        }
    }
    public class BigDog : Dog
    {
        public BigDog(string name) : base(name)
        {
        }
        public override void Greets()
        {
            Console.WriteLine("Wooow");
        }
        public override void Greets(Dog another)
        {
            Console.WriteLine("Woooow");
        }
        public void Greets(BigDog another)
        {
            Console.WriteLine("Woooooooow");
        }
    }
}
