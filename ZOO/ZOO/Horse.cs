using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class Horse : HorseFood, ITransferAnimals
    {
        public Horse(string name) : base(name) { }

      public string Location { get { return Location; } set { Location = value; } }
        public new void EatsApples()
        {
            Console.WriteLine("I eat  apples");
        }

        public new void ToTheVet()
        {
            Console.WriteLine("Once in a while I go to the vet to get shots");
        }

       

        public new void EatsCarrots()
        {
            Console.WriteLine("I eat carrots");
        }
    }  
}
