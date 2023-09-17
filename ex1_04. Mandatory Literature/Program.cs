namespace T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOfPages = int.Parse(Console.ReadLine());
            int PagesPerHour = int.Parse(Console.ReadLine());    
            int DaysNeeded = int.Parse(Console.ReadLine());

            int TotalTime = NumberOfPages / PagesPerHour;

            int ReqHours = TotalTime / DaysNeeded;

            Console.WriteLine(ReqHours);

        }
    }
}