namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("a:");
            string A = Console.ReadLine();
            double a = Convert.ToDouble(A);

            Console.WriteLine("b:");
            string B = Console.ReadLine();
            double b = Convert.ToDouble(B);

            Console.WriteLine("c:");
            string C = Console.ReadLine();
            double c = Convert.ToDouble(C);

            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($" x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"x = {root}");
            }
            else
            {
                Console.WriteLine("no solution");
            }
        }
    }
}
