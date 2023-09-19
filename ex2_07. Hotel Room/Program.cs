using System;

namespace ex2_07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Month - string("May", "June", "July", "August", "September" or "October")
            string month = Console.ReadLine();
            //•	Count of nights - an integer in the range[1... 200]
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month) 
            {
                case "May":
                case "October":
                    studioPrice = 50 * nights;
                    apartmentPrice = 65 * nights;

                    if (nights > 7 && nights <= 14) 
                    {
                        studioPrice -= studioPrice * 0.05;
                    }                        

                    else if (nights > 14) 
                    {
                        studioPrice -= studioPrice * 0.30;
                        apartmentPrice -= apartmentPrice * 0.10;
                    }
                    
                    break;

                case "June":
                case "September":
                    studioPrice = 75.20 * nights;
                    apartmentPrice = 68.70 * nights;

                    if (nights > 14) 
                    {
                        studioPrice -= studioPrice * 0.20;
                        apartmentPrice -= apartmentPrice * 0.10;
                    }                                       
                    break;

                case "July":
                case "August":
                    studioPrice = 76 * nights;
                    apartmentPrice = 77 * nights;

                    if (nights > 14) 
                    {
                        apartmentPrice -= apartmentPrice * 0.10;
                    }                   
                    break;


            }
            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            
        }
    }
}