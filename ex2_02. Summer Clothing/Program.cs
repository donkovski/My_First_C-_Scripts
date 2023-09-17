using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace ex2_02._Summer_Clothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            switch (day) 
            {
                case "Morning":
                    if (temp >= 10 && temp <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temp >= 25) 
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (temp >= 10 && temp <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (temp >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }                    
                    break;
                    


            }
            Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");
        }
        
    }
}