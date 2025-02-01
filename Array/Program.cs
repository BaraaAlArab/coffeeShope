using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeShope coffeeShope = new CoffeeShope();
            coffeeShope.DisplayCoffees();

            ItemCollection collection1 = new ItemCollection();
            collection1.AddItems(1, "Wael", "", true, 4.5, null);
            collection1.DisplayItems();

            ItemCollection collection2 = new ItemCollection();
            collection2.AddItems(100, "Chair", "Black", true, 40.5);
            collection2.AddItems(1, "Toyota", " ", false, 3.25, null);
            collection2.DisplayItems();
            
        }
    }
}
