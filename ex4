namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n) && n >= 0)
            {
                long factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"The factorial of {n} is {factorial}");
            }
            else
            {
                Console.WriteLine("Please enter a non negative integer.");
            }
        }
    }
}
