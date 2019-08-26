using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoprops
{
    class Garage
    {
        public int NumberOfCars { get; set; } = 1;
        public Car myAuto { get; set; } = new Car();

        public Garage() { }
        public Garage(Car car, int number)
        {
            myAuto = car;
            NumberOfCars = number;
        }
    }
}
