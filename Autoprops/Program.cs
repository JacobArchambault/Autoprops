using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoprops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            Car c = new Car();
            Garage g = new Garage();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStats();
            g.myAuto = c;

            Console.WriteLine("Number of Cars in garages: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.myAuto.PetName);

            Console.ReadLine();
        }
    }
}
