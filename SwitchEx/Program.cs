using System.Security.Cryptography.X509Certificates;

namespace SwitchEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a and b values");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter choice 1 for addition");
            Console.WriteLine("Enter choice 2 for substraction");
            Console.WriteLine("Enter choice 3 for multiplication");
            Console.WriteLine("Enter choice 4 for division");
            Console.WriteLine("Enter a choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    try
                    {

                        if (b != 0)
                            Console.WriteLine(a / b);
                        else
                            throw new DivideByZeroException();
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Divide by zero error occurred");
                    }
                    finally
                    {
                        Console.WriteLine("finally I am always executed");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }

        }
    }
}
/* Output
 * Enter a and b values
4
0
Enter choice 1 for addition
Enter choice 2 for substraction
Enter choice 3 for multiplication
Enter choice 4 for division
Enter a choice
4
Divide by zero error occurred
finally I am always executed
*/
