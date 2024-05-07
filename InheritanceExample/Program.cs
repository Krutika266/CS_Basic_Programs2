using System;
class Animal
{
    public void sound()
    {
        Console.WriteLine("Animal make sound");
    }
}
class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("Dog can bark");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        d.sound();
        d.bark();
    }
}
/* Output
 * Animal make sound
 * Dog can bark
 * */