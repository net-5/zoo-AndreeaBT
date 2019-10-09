﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Colt:Animal,IEat, ITransferAnimal
    {
        public Colt(string name) : base(name) { }
        private string location;
        private string food;
        public string Location
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
        public new string Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }
        public new void Eat()
        {
            return;
        }
    }
}
