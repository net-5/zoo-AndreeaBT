using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public  abstract class HorseFood : Zoo
    {
        public HorseFood(string name) : base (name)
        { }
        public void EatsApples() { }
        public void EatsCarrots() { }
   
    }
}
