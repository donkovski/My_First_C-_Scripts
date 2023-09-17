using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace ex2_01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string screening = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double income = 0.0;

            int allSeats = rows * cols;

            switch (screening)
                { case "Premiere":
                    income = allSeats * 12.00;
                    break;
                  case "Normal":
                    income = allSeats * 7.50;
                    break;
                  case "Discount":
                    income = allSeats * 5.00;
                    break;
                }                

            //if (screening == ("Premiere"))
            //{
            //    income = allSeats * 12.00;
            //}
            //else if (screening == ("Normal"))
            //{
            //    income = allSeats * 7.50;
            //}
            //else if (screening == ("Discount"))
            //{
            //    income = allSeats * 5.00;
            //}

            Console.WriteLine("{0:f2} leva", income);
        } 
    }
}