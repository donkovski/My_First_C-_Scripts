namespace ex2_06._Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	N1 – an integer value in the range [0...40 000]
            int numberOne = int.Parse(Console.ReadLine());
            //•	N2 – an integer value in the range [0...40 000]
            int numberTwo = int.Parse(Console.ReadLine());
            //•	Operator – one symbol among the following: "+", "-", "*", "/", "%"
            string symbol = Console.ReadLine();


            if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                string condition = "even";
                int sum = 0;

                if (symbol == "+")
                {
                    sum = numberOne + numberTwo;
                }
                else if (symbol == "-")
                {
                    sum = numberOne - numberTwo;
                }
                else if (symbol == "*")
                {
                    sum = numberOne * numberTwo;
                }

                if (sum % 2 == 1)
                {
                    condition = "odd";
                }
                Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {sum} - {condition}");
            }
            else if (symbol == "/" || symbol == "%")
            {
                if (numberTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
                else
                {
                    int result = 0;

                    if (symbol == "/")
                    {
                        result = numberOne / numberTwo;
                        Console.WriteLine($"{numberOne} / {numberTwo} = {result:F2}");
                    }
                    else if (symbol == "%")
                    {
                        result = numberOne % numberTwo;
                        Console.WriteLine($"{numberOne} % {numberTwo} = {result}");
                    }
                }
            }
        }
    }
}