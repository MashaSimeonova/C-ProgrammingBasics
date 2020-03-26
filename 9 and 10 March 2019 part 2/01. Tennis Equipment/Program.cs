using System;

namespace _01._Tennis_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTenisRocket = double.Parse(Console.ReadLine());
            int numbersRocket = int.Parse(Console.ReadLine());
            int numbersSneakers = int.Parse(Console.ReadLine());
             
            double tenisPrice = priceTenisRocket * numbersRocket;
            double sneakers = (priceTenisRocket * 1 / 6) * numbersSneakers;
            double otherThings = (tenisPrice + sneakers) * 0.20;
            double totalPrice = tenisPrice + sneakers + otherThings;
            double Jocovic = Math.Floor(totalPrice * 1 / 8);
            double Sponsored = Math.Ceiling(totalPrice * 7 / 8);
            Console.WriteLine($"Price to be paid by Djokovic {Jocovic}");
            Console.WriteLine($"Price to be paid by sponsors {Sponsored}");
        }
    }
}
