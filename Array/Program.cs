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
            //CoffeeShope coffeeShope = new CoffeeShope();
            //coffeeShope.AddCoffees();
            //coffeeShope.DisplayCoffees();

            //ItemCollection collection = new ItemCollection();
            //collection.AddItems();
            //collection.DisplayItems();

            //Console.WriteLine("this array is not dynamic data\n");
            //var arlist = new ArrayList() { 100, "Baraa", "KIA", 5.2 };
            //var arlist2 = new ArrayList() { 200, "Toyota", 52 };
            //arlist.AddRange(arlist2);
            //arlist2.AddRange(arlist);
            //Console.Write("ArrayList Element are:  ");
            //for (int i = 0; i < arlist.Count; i++)
            //{
            //    Console.Write(arlist[i] + "   ");
            //}
            var arr = new ArrayList() { 1, "HP", 300, 4.5 };
            var arr1 = new ArrayList() { 0, "Toyota", 4000, 5.5 };
            //int firstElement = (int)arr[0];
            //string secondElement = (string)arr[1];
            arr1.InsertRange(2, arr);
            //arr.Insert(1, "BMW");
            foreach (var item2 in arr1)
            {
                Console.WriteLine(item2);
            }
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(firstElement + " " + secondElement);

        }
    }
}