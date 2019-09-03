using System;
using System.Collections.Generic;
using System.Linq;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horsey = new Horse("Pepper");
            Console.WriteLine($"Hi, I am a horsey and my name is {horsey.Name}");
            horsey.EatsApples();
            horsey.ToTheVet();
            horsey.Location = "Small Stable";
            Console.WriteLine($"I will be moved in the {horsey.Location}");
            Console.WriteLine("\n");

            Horse horse = new Horse("Fargo");
            Console.WriteLine($"Hi, I am a horse and my name is {horse.Name}");
            horse.EatsCarrots();
            Console.WriteLine("\n");
            horse.Location = "Large Stable";
            Console.WriteLine($"I need space to exercise si I will stay in the {horse.Location}");

            Console.WriteLine();
            Penguin penguin = new Penguin("Pingu");
            Console.WriteLine($"Hi, I am a penguin and my name is {penguin.Name}");
            penguin.Eat();
            Console.WriteLine("\n");

            Snake snake = new Snake("Snakeeey");
            Console.WriteLine($"Hi, I am a snake and may anme is {snake.Name}");
            snake.Eat();
            Console.WriteLine("\n");

            Monkey monkey = new Monkey("Sara");
            Console.WriteLine($"Hi, I am a monkey and my name is {monkey.Name}");
            monkey.Eat();
            Console.WriteLine("\n");

            List<ITransferAnimals> transfer = new List<ITransferAnimals>();
            transfer.Add(horse);
            transfer.Add(horsey);
            var location = transfer.Select(x => x.Location).Distinct().ToString();
            Console.WriteLine(location);
            



        }
    }
}
