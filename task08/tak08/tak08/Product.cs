using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    internal class Product :IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id , string name , double price) 
        {
            Id = id;
            Name = name;
            Price = price;
        }    

        public int CompareTo(Object obj)
        {
            Product passedProd = (Product)obj;
          

            if (this.Price > passedProd.Price)
            {
                return 1;
            }
            else if (this.Price < passedProd.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
