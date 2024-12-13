using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal interface IMovable
    {

        void Move();

    }

    class CarForIMove : IMovable
    {
        public string Brand { get; set; }

        public CarForIMove( string brand)
        {
            
          Brand = brand;
        }
        public void Move()
        {
            Console.WriteLine($" The Moving Car Brand is : {Brand}");
        }
    }
}
