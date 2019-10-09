using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface ITransferAnimal
    {
        string Location { get; set; }
       
    }
    public class Zoo : ITransferAnimal
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public Zoo(string name) { Name = name; }
        
    }
}
