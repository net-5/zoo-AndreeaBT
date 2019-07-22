using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Penguin : Zoo, ITransferAnimals
    {
       

        public Penguin(string name) : base(name) { }
        public new void Eat()
        {

            Console.WriteLine("My favourite food is fish");
            return;
        }

        public new void ToTheVet()
        {
            Console.WriteLine("I haven't been to the vet in a long time, I'm a healthy pinguin.");
            return;
        }
    }
}