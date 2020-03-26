using System;

namespace _02._Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int minetsControl = int.Parse(Console.ReadLine());
            int secondsControl = int.Parse(Console.ReadLine());
            double lenghtMeters = double.Parse(Console.ReadLine());
            int secondsForHundredMeters = int.Parse(Console.ReadLine());

            double totalControlSec = minetsControl * 60 + secondsControl;
            double timeLost = (lenghtMeters / 120) * 2.5;
            double timeMartin = (lenghtMeters / 100) * secondsForHundredMeters - timeLost;
           

            if (timeMartin<=totalControlSec)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMartin:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(timeMartin - totalControlSec):f3} second slower.");
            }


        }
    }
}
