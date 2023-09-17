using System.Text.RegularExpressions;

namespace ex2_04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Group Budget -integer in the range[1... 8000]
            int budget = int.Parse(Console.ReadLine());
            //•	Season - string: "Spring", "Summer", "Autumn", "Winter"
            string season = Console.ReadLine();
            //•	Fishermen Count -integer in the range[4... 18]
            int fishermenCount = int.Parse(Console.ReadLine());

            double price = 0;
            double totalprice = 0;
            double finalprice = 0;

            switch (season) 
            {
                case "Spring":
                    price = 3000;
                        if (fishermenCount <= 6)
                    {
                        totalprice = price * 0.90;
                    }
                    else if (fishermenCount >= 7 && fishermenCount <= 11)
                    {
                        totalprice = price * 0.85;
                    }
                    else
                        totalprice = price * 0.75;
                    break;

                case "Summer":
                    price = 4200;
                    if (fishermenCount <= 6)
                    {
                        totalprice = price * 0.90;
                    }
                    else if (fishermenCount >= 7 && fishermenCount <= 11)
                    {
                        totalprice = price * 0.85;
                    }
                    else
                        totalprice = price * 0.75;
                    break;

                case "Autumn":
                    price = 4200;
                    if (fishermenCount <= 6)
                    {
                        totalprice = price * 0.90;
                    }
                    else if (fishermenCount >= 7 && fishermenCount <= 11)
                    {
                        totalprice = price * 0.85;
                    }
                    else
                        totalprice = price * 0.75;
                    break;

                case "Winter":
                    price = 2600;
                    if (fishermenCount <= 6)
                    {
                        totalprice = price * 0.90;
                    }
                    else if (fishermenCount >= 7 && fishermenCount <= 11)
                    {
                        totalprice = price * 0.85;
                    }
                    else
                        totalprice = price * 0.75;
                    break;
                                                          
            }
            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                finalprice = totalprice * 0.95;
            }
            else finalprice = totalprice;

            if (budget >= finalprice)
            {
                Console.WriteLine($"Yes! You have {budget - finalprice:F2} leva left.");
            }
            else if (budget < finalprice)
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - finalprice):F2} leva.");


        }
    }
}