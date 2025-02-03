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
            coffeeTypes = new List<string>();
        }
        public void AddCoffees()
        {
            Console.WriteLine("Enter the number of coffee types you want to add: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter Coffee Type {i + 1}:");
                coffeeTypes.Add(Console.ReadLine());
            }
        }
        public void DisplayCoffees()
        {
            Console.Write("Different types of coffee;" + string.Join(",   ",coffeeTypes));
        }
    }
}
