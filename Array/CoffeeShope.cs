using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class CoffeeShope
    {
        private List<string> coffeeTypes;
        public CoffeeShope() 
        {
            coffeeTypes = new List<string>{ "Americano", "Cafe au lait", "Espresso", "Cappuccino", "Macchiato" };
        }
        public void DisplayCoffees()
        {
            Console.WriteLine("Different types of coffee:\t"+ string.Join(",",coffeeTypes));
            //foreach (string coffee in coffeeTypes)
            //{ ***here also work with line by line not on a same line***
            //    Console.WriteLine(coffee);
            //}
        }
    }
}
