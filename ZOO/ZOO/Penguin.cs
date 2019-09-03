using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Penguin : Zoo
    {
       

        public Penguin(string name) : base(name) { }
       
        public new void Eat()
        {

            Console.WriteLine("My favourite food is fish");
            return;
        }

       
    }
}