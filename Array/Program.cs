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
            CoffeeShope coffeeshope = new CoffeeShope();
            coffeeshope.AddCoffees();
            coffeeshope.DisplayCoffees();

            ItemCollection collection = new ItemCollection();
            collection.AddItems();
            collection.DisplayItems();

            Console.WriteLine("this array is not dynamic data\n");
            var arlist = new ArrayList() { 100, "Baraa", "KIA", 5.2 };
            var arlist2 = new ArrayList() { 200, "Toyota", 52 };
            arlist.AddRange(arlist2);
            arlist2.AddRange(arlist);
            Console.Write("ArrayList Element are:  ");
            for (int i = 0; i < arlist.Count; i++)
            {
                Console.Write(arlist[i]+"   ");
            }
            
        }
    }
}
