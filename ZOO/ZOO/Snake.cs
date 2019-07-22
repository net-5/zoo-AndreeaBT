using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class Snake : Zoo, ITransferAnimals
    {
        public Snake(string name) : base(name) { }
        public string Location
        {
            get
            {
                return Location;
            }
            set
            {
                Location = value;
            }
        }

        public new void Eat()
        {
            Console.WriteLine("I eat mouses");
            return;
        }
       
        public new void ToTheVet()
        {
            Console.WriteLine("I have once been to the vet, it was awfull");
            return;
        }
      
    }
}
