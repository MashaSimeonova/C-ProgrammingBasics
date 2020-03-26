using System;

namespace _06._Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int winPointsDesi = 0;
            int lostPoints = 0;
            int counterWins = 0;
            int counterLost = 0;
            int tournamentCounter = 0;
            
            string tournament = "";

            while (command != "End of tournaments")
            {
                tournament = command;
                int games = int.Parse(Console.ReadLine());
                tournamentCounter += games;

                for (int i = 1; i <= games; i++)
                {
                    int desiPoinst = int.Parse(Console.ReadLine());
                    int teamPoinst = int.Parse(Console.ReadLine());
                    winPointsDesi = 0;
                    lostPoints = 0;
                    if (desiPoinst>teamPoinst)
                    {
                        counterWins += 1;
                        winPointsDesi = desiPoinst - teamPoinst;
                        Console.WriteLine($"Game {i} of tournament {tournament}: win with {winPointsDesi} points.");
                    }
                    else
                    {
                        counterLost += 1;
                        lostPoints = teamPoinst - desiPoinst;
                        Console.WriteLine($"Game {i} of tournament {tournament}: lost with {lostPoints} points.");
                    }
                    
                }
                command = Console.ReadLine();
            }

            double winPercent = (double)counterWins / tournamentCounter * 100;
            double lostPercent = (double)counterLost / tournamentCounter * 100;
            Console.WriteLine($"{winPercent:f2}% matches win");
            Console.WriteLine($"{lostPercent:f2}% matches lost");

        }
    }
}
