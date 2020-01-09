using System;

namespace Autoprops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            Car c = new Car();
            Garage g = new Garage();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStats();
            g.MyAuto = c;

            Console.WriteLine("Number of Cars in garages: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);

            Console.ReadLine();
        }
    }
}
