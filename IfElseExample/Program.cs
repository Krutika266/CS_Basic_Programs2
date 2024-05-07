using System;
namespace Hello
{
    public class Hello
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}

/*Output
 * 5
 * Odd
 * */