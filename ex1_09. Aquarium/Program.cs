namespace T09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percentege = double.Parse(Console.ReadLine());

            int volumeAquarium = length * width * hight;
            double volumeInLiters = volumeAquarium / 1000.0;
            double Occupied = percentege / 100;

            double requiredLiters = volumeInLiters * (1 - Occupied);

            Console.WriteLine("{0:0.00}", requiredLiters);

        }
    }
}