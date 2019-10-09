using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface IEat
    {
        void Eat();
        string Food { get; set; }
    }
    public abstract class Animal:IEat
    {
        public string Name { get; set; }
        public string Food { get; set; }

        public Animal(string name) { Name = name; }
        public void Eat()
        {
            
        }
    }
}
