using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Guess_the_Password
{
    internal class Guess_the_Password
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (password == "s3cr3t!")
            {
                Console.WriteLine("Welcome");
            }
            else 
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}