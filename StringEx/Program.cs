namespace StringEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Kruti";
            String ss = "Krutika";
            Console.WriteLine(s);
            Console.WriteLine(ss);
            char[] ch = { 'a', 'b', 'c' };
            string s2 = new string(ch);
            Console.WriteLine(s2);
            Console.WriteLine("String Concatination");
            Console.WriteLine(s+ss);
        }
    }
}
