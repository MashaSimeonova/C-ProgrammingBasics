using System;

namespace _01Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());

            double priceShoes = taxPerYear * 0.60;
            double priceClothes = priceShoes * 0.80;
            double priceBoll = priceClothes * 1 / 4;
            double priceThings = priceBoll * 1 / 5;
            double totalExpanse = taxPerYear + priceBoll + priceClothes + priceShoes + priceThings;

            Console.WriteLine($"{totalExpanse:f2}");
        }
    }
}
