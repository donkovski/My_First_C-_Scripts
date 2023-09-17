namespace T07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Number of chicken menus – integer in the range[0... 99]
            int chicken = int.Parse(Console.ReadLine());
            //•	Number of menus with fish – integer in the range[0... 99]
            int fish = int.Parse(Console.ReadLine());
            //•	Number of vegetarian menus – an integer in the range[0... 99]
            int vegetarian = int.Parse(Console.ReadLine());

            double chickenPrice = chicken * 10.35;
            double fishPrice = fish * 12.40;
            double vegetarianPrice = vegetarian * 8.15;

            double totalMenuCost = chickenPrice + fishPrice + vegetarianPrice;

            double desert = totalMenuCost * 0.20;
            double deliveryPrice = 2.50;

            double totalPrice = totalMenuCost + desert +deliveryPrice;

            Console.WriteLine(totalPrice);
        }
    }
}