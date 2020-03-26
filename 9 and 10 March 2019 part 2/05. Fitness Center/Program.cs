using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfpeople = int.Parse(Console.ReadLine());
            int counterBack = 0;
            int counterChest = 0;
            int counterLegs = 0;
            int counterAbs = 0;
            int counterProteinBar = 0;
            int counterShake = 0;
            int exersice = 0;
            int product = 0;

            for (int i = 0; i < numbersOfpeople; i++)
            {
                string type = Console.ReadLine();

                switch (type)
                {

                    case "Back":
                        counterBack += 1;
                        exersice += 1;
                        break;
                    case "Chest":
                        counterChest += 1;
                        exersice += 1;
                        break;
                    case "Legs":
                        counterLegs += 1;
                        exersice += 1;
                        break;
                    case "Abs":
                        counterAbs += 1;
                        exersice += 1;
                        break;
                    case "Protein shake":
                        counterShake += 1;
                        product += 1;
                        break;
                    case "Protein bar":
                        counterProteinBar += 1;
                        product += 1;
                        break;
                   
                    default:
                        break;
                }
            }
            double percentOfexercise = (double)exersice / numbersOfpeople * 100;
            double percentOfProduct = (double)product / numbersOfpeople * 100;
            Console.WriteLine($"{counterBack} - back");
            Console.WriteLine($"{counterChest} - chest");
            Console.WriteLine($"{counterLegs} - legs");
            Console.WriteLine($"{counterAbs} - abs");
            Console.WriteLine($"{counterShake} - protein shake");
            Console.WriteLine($"{counterProteinBar} - protein bar");
            Console.WriteLine($"{percentOfexercise:f2}% - work out");
            Console.WriteLine($"{percentOfProduct:f2}% - protein");

        }
    }
}
