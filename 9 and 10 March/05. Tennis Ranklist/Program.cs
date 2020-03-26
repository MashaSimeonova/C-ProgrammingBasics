using System;

namespace _05._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfgames = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            double points = 0;
            double avaragePoints = 0;
            int counterWins = 0;

            for (int i = 0; i < numberOfgames; i++)
            {
                string typeOfwin = Console.ReadLine();

                switch (typeOfwin)
                {
                    case "W":
                        points += 2000;
                        counterWins += 1; break;
                    case "F":
                        points += 1200; break;
                    case "SF":
                        points += 720; break;

                    default:
                        break;
                }

            }
            double finalPoint = points + startPoints;
            avaragePoints = Math.Floor(points / numberOfgames);
            double percentOfwins = (double)counterWins / numberOfgames * 100;

            Console.WriteLine($"Final points: {finalPoint}");
            Console.WriteLine($"Average points: {avaragePoints}");
            Console.WriteLine($"{percentOfwins:f2}%");
        }
    }
}
