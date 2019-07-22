using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class Zoo : ITransferAnimals
    {
        public string Name { get; set; }
        public string Location { get { return Location; }set { Location = "I am going to live in the Zoo \'New Beginnings\' "; } }

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
