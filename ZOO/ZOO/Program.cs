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
            Console.WriteLine("\n");

            Horse horse = new Horse("Fargo");
            Console.WriteLine($"Hi, I am a horse and my name is {horse.Name}");
            horse.EatsCarrots();
            Console.WriteLine("\n");

            Penguin penguin = new Penguin("Pingu");
            Console.WriteLine($"Hi, I am a penguin and my name is {penguin.Name}");
            penguin.Eat();
            penguin.ToTheVet();
            Console.WriteLine("\n");

            Snake snake = new Snake("Snakeeey");
            Console.WriteLine($"Hi, I am a snake and may anme is {snake.Name}");
            snake.Eat();
            snake.ToTheVet();
            Console.WriteLine("\n");

            Monkey monkey = new Monkey("Sara");
            Console.WriteLine($"Hi, I am a monkey and my name is {monkey.Name}");
            monkey.Eat();
            monkey.ToTheVet();
            Console.WriteLine("\n");

            List<ITransferAnimals> transfer = new List<ITransferAnimals>();
            transfer.Add(horse);
            transfer.Add(snake);
            var location = transfer.Select(x => x.Location).Distinct().ToString();
            Console.WriteLine(location);
            



        }
    }
}
