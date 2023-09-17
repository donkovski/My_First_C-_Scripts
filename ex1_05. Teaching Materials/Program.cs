namespace T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());   

            double penPrice = pens * 5.80;
            double markerPrice = markers * 7.20;
            double cleanerPrice = cleaner * 1.20;

            double totalPrice = penPrice + markerPrice + cleanerPrice;

            double FinalPrice = totalPrice - (totalPrice * discount / 100);

            Console.WriteLine(FinalPrice);

        }
    }
}