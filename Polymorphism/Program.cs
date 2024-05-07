using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog can barks");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Animal a = new Animal();
        Dog d = new Dog();

        a.MakeSound();

        d.MakeSound();
    }
}
/* Output
 * Animal makes a sound.
 * Dog can barks
 * */
