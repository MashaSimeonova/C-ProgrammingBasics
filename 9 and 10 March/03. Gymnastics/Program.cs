using System;

namespace _03._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string contry = Console.ReadLine();
            string type = Console.ReadLine();
            double totalPoints = 0;
            

            if (contry == "Russia")
            {
                switch (type)
                {
                    case "ribbon":
                        totalPoints = 9.100 + 9.400;
                        break;
                    case "hoop":
                        totalPoints = 9.300 + 9.800;
                        break;
                    case "rope":
                        totalPoints = 9.600 + 9.000;
                        break;
                    default:
                        break;
                }
            }
            else if (contry == "Bulgaria")
            {
                switch (type)
                {
                    case "ribbon":
                        totalPoints = 9.600 + 9.400;
                        break;
                    case "hoop":
                        totalPoints = 9.550 + 9.750;
                        break;
                    case "rope":
                        totalPoints = 9.500 + 9.400;
                        break;
                    default:
                        break;
                }
            }
            else if (contry == "Italy")
            {
                switch (type)
                {
                    case "ribbon":
                        totalPoints = 9.200 + 9.500;
                        break;
                    case "hoop":
                        totalPoints = 9.450 + 9.350;
                        break;
                    case "rope":
                        totalPoints = 9.700 + 9.150;
                        break;
                    default:
                        break;
                }
            }
            double percent = Math.Abs(20 - totalPoints);
            double finalPercent = percent / 20 * 100;
            Console.WriteLine($"The team of {contry} get {totalPoints:f3} on {type}.");
            Console.WriteLine($"{finalPercent:f2}%");
            

        }
    }
}
