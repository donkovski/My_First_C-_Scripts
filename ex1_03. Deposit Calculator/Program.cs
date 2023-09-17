namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double DepAmmount = double.Parse(Console.ReadLine());                 
            int months = int.Parse(Console.ReadLine());              
            double interest = double.Parse(Console.ReadLine());

            double accInterest = DepAmmount * interest / 100;
            double interestForOneMonth = accInterest / 12;
            double tottalAmmount = DepAmmount + months * interestForOneMonth;

            Console.WriteLine(tottalAmmount);

           }
    }
}