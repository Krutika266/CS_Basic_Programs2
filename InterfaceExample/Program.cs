using System;

namespace MyApplication
{

    interface vehicle
    {
        void move();
    }


    class car : vehicle
    {
        public void move()
        {

            Console.WriteLine("Car can move");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.move();
        }
    }
}
/* Output
 * Car can move
 * */