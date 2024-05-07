using System;
namespace Student
{
    class Student
    {
        public string name;

        public Student()
        {
            name = "Krutika";
        }

        static void Main(string[] args)
        {
            Student stud = new Student();
            Console.WriteLine(stud.name);
        }
    }
}
/* Output
 * Krutika
 * */