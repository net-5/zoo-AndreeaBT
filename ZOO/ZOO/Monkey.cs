using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class Monkey :Zoo
    {
        public Monkey (string name) : base(name) { }
        public string Bananas { get; set; }
        public new void Eat()
        {

            Console.WriteLine("I eat bananas");
            return;
        }
       
      
    }
}
