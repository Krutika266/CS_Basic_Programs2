using System;
namespace Hello
{
    public class Dog
    {
        string name = "Alexa";
        static void Main(String[] args)
        {
            Dog d = new Dog();
            Console.WriteLine(d.name);
        }
    }
}

/* Output
 * Alexa
 * */