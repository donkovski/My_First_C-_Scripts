using System;

namespace ex2_04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double cost = 0.0;
            string holiday = "";
            string location = "";

            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        location = "Bulgaria";
                        cost = budget * 0.30;
                        holiday = "Camp";
                    }
                    else if (budget <= 1000)
                    {
                        location = "Balkans";
                        cost = budget * 0.40;
                        holiday = "Camp";
                    }
                    else if (budget > 1000)
                    {
                        location = "Europe";
                        cost = budget * 0.90;
                        holiday = "Hotel";
                    }
                    break;

                case "winter":
                    if (budget <= 100)
                    {
                        location = "Bulgaria";
                        cost = budget * 0.70;
                        holiday = "Hotel";
                    }
                    else if (budget <= 1000)
                    {
                        location = "Balkans";
                        cost = budget * 0.80;
                        holiday = "Hotel";
                    }
                    else if (budget > 1000)
                    {
                        location = "Europe";
                        cost = budget * 0.90;
                        holiday = "Hotel";
                    }
                    break;
            }
            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{holiday} - {cost:F2}");
        }
    }
}