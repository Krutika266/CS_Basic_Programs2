abstract class Bird
{
    public abstract void makeSound();
    public void fly()
    {
        Console.WriteLine("Bird can  fly");
    }
}
class Pigeon : Bird
{
    public override void makeSound()
    {
        Console.WriteLine("Pigeon can make sound");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pigeon p = new Pigeon();
        p.makeSound();
        p.fly();
    }
 }