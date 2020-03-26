using System;

namespace _03._World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfgame = Console.ReadLine();
            string ticket = Console.ReadLine();
            int numbOfTickets = int.Parse(Console.ReadLine());
            string picture = Console.ReadLine();
            double price = 0;
            double finalPrice = 0;

            if (typeOfgame == "Quarter final")
            {
                switch (ticket)
                {
                    case "Standard":
                        price = numbOfTickets * 55.50;
                        break;
                    case "Premium":
                        price = numbOfTickets * 105.20;
                        break;
                    case "VIP":
                        price = numbOfTickets * 118.90;
                        break;
                    default:
                        break;
                }
            }
            else if (typeOfgame == "Semi final")
            {
                switch (ticket)
                {
                    case "Standard":
                        price = numbOfTickets * 75.88;
                        break;
                    case "Premium":
                        price = numbOfTickets * 125.22;
                        break;
                    case "VIP":
                        price = numbOfTickets * 300.40;
                        break;
                    default:
                        break;
                }
            }
            else if (typeOfgame == "Final")
            {
                switch (ticket)
                {
                    case "Standard":
                        price = numbOfTickets * 110.10;
                        break;
                    case "Premium":
                        price = numbOfTickets * 160.66;
                        break;
                    case "VIP":
                        price = numbOfTickets * 400.00;
                        break;
                    default:
                        break;
                }
            }

            if (price > 4000 && picture == "Y" || price > 4000 || price > 4000 && picture == "N")
            {
                finalPrice = price * 0.75;
            }
            else if (price > 2500 && price <= 4000 && picture == "Y")
            {
                finalPrice = price * 0.90 + numbOfTickets * 40;
            }
            else if (price > 2500 && price <= 4000 && picture == "N")
            {
                finalPrice = price * 0.90;
            }
            else if (price <= 2500 && picture == "Y")
            {
                finalPrice = price + numbOfTickets * 40;
            }
            else
            {
                finalPrice = price;
            }

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
