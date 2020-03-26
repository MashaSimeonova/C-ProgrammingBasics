using System;

namespace _04._Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();
            string command = Console.ReadLine();
            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            while (command!= "End of game")
            {
                int firstCard = int.Parse(command);
                int secondCard = int.Parse(Console.ReadLine());
                if (firstCard>secondCard)
                {
                    firstPlayerPoints += (firstCard - secondCard);
                }
                else if (firstCard==secondCard)
                {
                    firstCard = int.Parse(Console.ReadLine());
                    secondCard = int.Parse(Console.ReadLine());
                    if (firstCard>secondCard)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{firstPlayer} is winner with {firstPlayerPoints} points");break;
                    }
                    else
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{secondPlayer} is winner with {secondPlayerPoints} points"); break;
                    }
                }
                else
                {
                    secondPlayerPoints += (secondCard - firstCard);
                }
                command = Console.ReadLine();
            }
            if (command == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {firstPlayerPoints} points");
                Console.WriteLine($"{secondPlayer} has {secondPlayerPoints} points");
            }
        }
    }
}
