using System.ComponentModel.Design;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace ex_03._New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();            
            int flowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            switch (typeFlowers) 
            {
                case "Roses":
                    price = flowers * 5;
                    if (flowers > 80)
                        {
                        price = price * 0.9;
                        }
                    break;
                case "Dahlias":
                    price = flowers * 3.80;
                    if (flowers > 90)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Tulips":
                    price = flowers * 2.80;
                    if (flowers > 80)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Narcissus":
                    price = flowers * 3.00;
                    if (flowers < 120)
                    {
                        price = price * 1.15;
                    }
                    break;
                case "Gladiolus":
                    price = flowers * 2.50;
                    if (flowers < 80)
                    {
                        price = price * 1.20;
                    }
                    break;

            } if (budget < price)
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - price):F2} leva more.");

            }
            else
                Console.WriteLine($"Hey, you have a great garden with {flowers} {typeFlowers} and {budget - price:F2} leva left.");
        } 
    }
}