using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class Snake : Zoo
    {
        public Snake(string name) : base(name) { }
       

        public new void Eat()
        {
            Console.WriteLine("I eat mouses");
            return;
        }
       
       
      
    }
}
