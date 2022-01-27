using System;

namespace SimpleClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Fun with Simple Class!****");
            var myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;
            myCar.PrintState();
        }
    }
}
