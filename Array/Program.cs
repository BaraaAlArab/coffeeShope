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
            coffeeShope.AddCoffees();
            coffeeShope.DisplayCoffees();

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
                Console.Write(arlist[i] + "   ");
            }
            var arr = new ArrayList() { 1, "TurkishCoffee", 3, 4.5 };
            var arr1 = new ArrayList() { 0, "ArabicCoffee", 4, 5.5 };
            int firstElement = (int)arr[0];
            string secondElement = (string)arr[1];
            arr1.InsertRange(2, arr);
            arr.Insert(1, "icedCoffee");
            foreach (var item2 in arr1)
            {
                Console.WriteLine(item2);
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(firstElement + " " + secondElement);
            var arr3 = new ArrayList();
            arr3.Add(100);
            arr3.Add("Soha");
            arr3.Add(300);
            arr3.Add("Ah");
            arr3.Add(4.5);
            arr3.Add(300);
            arr3.Remove("Soha");
            arr3.RemoveAt(2);
            arr3.RemoveRange(0, 4);
            Console.WriteLine("Remove the array in the index 0:\n");
            for (int i = 0; i < arr3.Count; i++)
            {
                Console.WriteLine(arr3[i]);
            }
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }




        }
    }
}