using System;

class Student
{

    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Student s1 = new Student();


        s1.Name = "Krutika";
        s1.Age = 20;


        s1.DisplayInfo();
    }
}
/* Output
 * Name: Krutika, Age: 20
 * */