using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Monkey :Zoo, ITransferAnimals
    {
        public Monkey (string name) : base(name) { }
        public string Bananas { get; set; }
        public new void Eat()
        {

            Console.WriteLine("I eat bananas");
            return;
        }
        public new void ToTheVet()
        {
            Console.WriteLine("I always go to the vet because I eat junk that I found in the enclosure");
            return;
        }
      
    }
}
