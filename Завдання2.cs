
namespace ConsoleApp2
{
  class Program
  {
    static void Main(String[] args)
    {
        int[] a = new int[8];
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        int rate = 0;
        int cnt = 0;
        for (int i = 1; i < a.Length; i++)
        {
            a[i]=Convert.ToInt32(Console.ReadLine());
            min = Math.Min(a[i], min);
            max = Math.Max(a[i], max);
            cnt += a[i];
            Console.WriteLine("day "+i+" = " +a[i]);
            
            if (rate < a[i]) { Console.WriteLine("rate fell"); rate=a[i]; }
            else { Console.WriteLine("rate did not fell"); rate=a[i]; }
        }
        Console.WriteLine("high price: "+ max);
        Console.WriteLine("low  price: "+ min);
        Console.WriteLine("high price - low price : "+ (max-min));
        Console.WriteLine("the average: "+ (cnt/7));
        
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] == min)
            {
                int ChangeTheLowestPrice = Convert.ToInt32(Console.ReadLine());
                a[i] = ChangeTheLowestPrice;
            }
        }
    }
  }
}
