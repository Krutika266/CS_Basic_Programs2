namespace StatGeneric
{
    public static class StatGeneric
    {
        public static void Print<T>(T item)
        {
            Console.WriteLine(item);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StatGeneric.Print<int>(10);
            StatGeneric.Print<string>("Hello");
        }
    }
}
/* Output
 * 10
 * Hello
 * */
