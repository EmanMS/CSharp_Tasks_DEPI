using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    internal interface IVehicle
    {
        void StartEngine();
        void StopEngine();

    }

    class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("CarEngine has started");
        }

        public void StopEngine()
        {
            Console.WriteLine("CarEngine has stopped");
        }
    }

    class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("BikeEngine has startes");
        }

        public void StopEngine()
        {
            Console.WriteLine("BikeEngine has stopped");
        }
    }

}
