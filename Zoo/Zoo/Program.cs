using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            



            Pig pig = new Pig("Viorica");
            Zoo zooo = new Zoo("International Zoo");
            pig.Location = "The golden house";
            pig.Food = "watermelon";
            Console.WriteLine($"My name is {pig} I live at the {zooo} in the {pig.Location} and my favoutire food is {pig.Food}");
            Console.WriteLine();

            Chicken chicken = new Chicken("Maria");
            Zoo zoo = new Zoo("Public Zoo Iasi");
            chicken.Location = "hen coop";
            chicken.Food = "grain";
            Console.WriteLine($"My name is {chicken} I live at the {zoo} in the {chicken.Location} and my favourite food is {chicken.Food}");
            Console.WriteLine();

            Zoo zo = new Zoo("New Beginings Zoo");
            Colt colt = new Colt("Junior");
            colt.Location = "nursery";
            colt.Food = "apples";
            Console.WriteLine($"My name is {colt} I live at the {zo} in the {colt.Location} and my favourite food is {colt.Food}");
            Console.WriteLine();

            Stalion stalion = new Stalion("Fargo");
            stalion.Location = "barn";
            stalion.Food = "carrots";
            Console.WriteLine($"My name is {stalion} I live at the {zoo} in the {stalion.Location} and my favourite food is {stalion.Food}");

            List<ITransferAnimal> transfer = new List<ITransferAnimal>();
            transfer.Add(pig);
            transfer.Add(chicken);
            var Location = transfer.Select(x => x.Location).Distinct().Count();
            Console.WriteLine($"The are {Location} locations that need to be ready for the transfer of the animals");
        }
    }
}
