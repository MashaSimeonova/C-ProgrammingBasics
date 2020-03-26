using System;

namespace _02._Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstGame = Console.ReadLine();
            string SecondGame = Console.ReadLine();
            string ThirdGame = Console.ReadLine();
            int wonCounter = 0;
            int lostCounter = 0;
            int drowCounter = 0;

            char HosteDigit = firstGame[0];
            char GestdDigit = firstGame[2];
            if (HosteDigit>GestdDigit)
            {
                wonCounter += 1;
            }
            else if (HosteDigit<GestdDigit)
            {
                lostCounter += 1;
            }
            else if (HosteDigit==GestdDigit)
            {
                drowCounter += 1;
            }
            char Hoste2Digit = SecondGame[0];
            char Gestd2Digit = SecondGame[2];
            if (Hoste2Digit > Gestd2Digit)
            {
                wonCounter += 1;
            }
            else if (Hoste2Digit < Gestd2Digit)
            {
                lostCounter += 1;
            }
            else if (Hoste2Digit == Gestd2Digit)
            {
                drowCounter += 1;
            }
            char Hoste3Digit = ThirdGame[0];
            char Gestd3Digit = ThirdGame[2];
            if (Hoste3Digit > Gestd3Digit)
            {
                wonCounter += 1;
            }
            else if (Hoste3Digit < Gestd3Digit)
            {
                lostCounter += 1;
            }
            else if (Hoste3Digit == Gestd3Digit)
            {
                drowCounter += 1;
            }
            Console.WriteLine($"Team won {wonCounter} games.");
            Console.WriteLine($"Team lost {lostCounter} games.");
            Console.WriteLine($" Drawn games: {drowCounter}");
        }
    }
}
