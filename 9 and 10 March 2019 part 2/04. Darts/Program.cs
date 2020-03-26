using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string command = Console.ReadLine();
            int counterShots = 0;
            int totalScore = 301;
            int finalPoints = 0;
            int badShots = 0;
            

            while (command != "Retire")
            {
                string typeOfShot = command;
                int point = int.Parse(Console.ReadLine());
                finalPoints = 0;
                
                if (typeOfShot == "Single")
                {
                    finalPoints = point;
                    
                }
                else if (typeOfShot == "Double")
                {
                    finalPoints = point * 2;
                    
                }
                else if (typeOfShot == "Triple")
                {
                    finalPoints= point * 3;
                    
                }
                counterShots += 1;
                if (totalScore < finalPoints)
                {
                    counterShots -= 1;
                    badShots += 1;
                    
                }
                else
                {
                    totalScore -= finalPoints;
                }
                if (totalScore == 0)
                {
                    Console.WriteLine($"{playerName} won the leg with {counterShots} shots.");break;
                }
                command = Console.ReadLine();
            }
            if (command == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {badShots} unsuccessful shots.");
            }
        }
    }
}
