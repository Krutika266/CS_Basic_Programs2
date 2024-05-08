using System;
public class InvalidAgeException : Exception
{
  
    public InvalidAgeException(String message)
         : base(message)
    {
    }
}
public class TestUserDefinedException
{
    static void validate(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age is less than 18");
        }
    }
    public static void Main(string[] args)
    {
        try
        {
            validate(12);
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e);
        }
    }
}
