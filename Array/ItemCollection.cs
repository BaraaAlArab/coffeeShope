using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ItemCollection
    {
        private ArrayList items;

        public ItemCollection()
        {
            items = new ArrayList();
        }
        public void AddItems (params object[] newItems)
        {
            items.AddRange(newItems);
        }
        public void DisplayItems()
        {
            Console.WriteLine("\nItems in the collection:\t" + string.Join(",", items.ToArray()).Replace(", ,",", null"));
            //foreach (var item in items) 
            //here used line by line not on straight line
            //{ 
                
            //    Console.WriteLine(item ?? "null"); 
            //}
        }
    }
}
