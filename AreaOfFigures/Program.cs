using System.ComponentModel.Design;

namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0;

            if (type == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                area = sideA * sideA;
                Console.WriteLine($"{area:f2}");
            }
            else if (type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
                Console.WriteLine($"{area:f2}");
            }
            else if (type == "circle") 
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:f2}");
            }            
            else
            Console.WriteLine("Invalid figure.");
        }
    }
}