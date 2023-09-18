
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size: ");
            size = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter string {i+1}:");
                array[i] = Console.ReadLine();
            }
            string fstring;
            Console.WriteLine("Enter the string to search for: ");
            fstring = Console.ReadLine();
            for (int i = 0; i < size; i++)
            {
                if (array[i].Contains(fstring))
                {
                    Console.WriteLine($"string {i+1}: " + array[i]);
                    break; 
                    
                }
            }
        }
    }
}
