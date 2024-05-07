namespace EnumEx
{
    public enum Dept
    {
        Marketing,
        HR,
        Sales
    }
    public class Emp
    {
        public String Name
        { get; set; }
        public Dept Dept { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp { Name = "Kruti", Dept = Dept.Marketing };
            Console.WriteLine($"Employee Name : {e1.Name}");
            Console.WriteLine($"Employee Department : {e1.Dept}");
        }
    }
}
/* Output
 * Employee Name : Kruti
Employee Department : Marketing
*/
