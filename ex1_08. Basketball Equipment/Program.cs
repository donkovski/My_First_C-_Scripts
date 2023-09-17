namespace T08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int BasketTraining = int.Parse(Console.ReadLine());

            double sneakers = BasketTraining * 0.60;
            double team = sneakers * 0.80;
            double basketball = team * 0.25;
            double accessories = basketball * 0.20;

            double totalPrice = BasketTraining + sneakers + team +basketball + accessories;

            Console.WriteLine(totalPrice);
        }
    }
}