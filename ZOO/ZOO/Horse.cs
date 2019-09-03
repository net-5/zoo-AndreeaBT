using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class Horse : Zoo, HorseFood, ITransferAnimals
    {
        public Horse(string name) : base(name) { }

        private string location;
        public new string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public  void EatsApples()
        {
            Console.WriteLine("I eat  apples");
        }

        public new void ToTheVet()
        {
            Console.WriteLine("Once in a while I go to the vet to get shots");
        }

       

        public  void EatsCarrots()
        {
            Console.WriteLine("I eat carrots");
        }
       
    }  
}
