using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class Zoo : ITransferAnimals
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public Zoo(string name) { Name = name;}

      
        public virtual void Eat() { }
        
      

        public virtual void ToTheVet()
        {
           
        }

        public void AnotherZoo()
        {
            
        }
    }
}
