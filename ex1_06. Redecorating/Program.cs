namespace T06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hoursNeededForCraftMan = int.Parse(Console.ReadLine());
            double bag = 0.40;

            double nylonAmmount = ((nylon + 2) * 1.50);
            double paintAmmount = paint * 1.10 * 14.50;
            double thinnerAmmount = thinner * 5.00;

            double totalAmmountOfMaterials = nylonAmmount + paintAmmount + thinnerAmmount + bag;
            double ammountOfCraftMan = totalAmmountOfMaterials * 0.30 * hoursNeededForCraftMan;

            double totalCost = totalAmmountOfMaterials + ammountOfCraftMan;

            Console.WriteLine(totalCost);


        }
    }
}