﻿namespace Boiling_Water
{
    internal class Boiling_Water
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());

            if (temperature > 100)
            {
                Console.WriteLine("The water is boiling");
            }
            else 
            {
                Console.WriteLine("The water is not hot enough");
            }
        }
    }
}