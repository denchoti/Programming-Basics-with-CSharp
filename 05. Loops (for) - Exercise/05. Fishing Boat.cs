using System;

namespace _15.FishingBoat
{
    class Program
    {
   
        
            static void Main(string[] args)
            {

                int budget = int.Parse(Console.ReadLine());
                string season = Console.ReadLine();
                int fishermen = int.Parse(Console.ReadLine());

                double price = 0;


                switch (season)
                {
                    case "Spring":

                        price = 3000;
                        break;

                    case "Summer":

                        price = 4200;
                        break;

                    case "Autumn":

                        price = 4200;
                        break;

                    case "Winter":

                        price = 2600;
                        break;
                }

                if (fishermen <= 6)
                {
                    price = price - price * 0.1;
                }
                else if (fishermen >= 7 && fishermen <= 11)
                {
                    price = price - price * 0.15;
                }
                else if (fishermen >= 12)
                {
                    price = price - price * 0.25;
                }


                if (fishermen % 2 == 0 && season != "Autumn")
                {
                    price = price - price * 0.05;
                }


                if (budget >= price)
                {
                    Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
                }

            }
        }
    }
