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
        public void AddItems ()
        {
            Console.Write("Enter the number of items you want to add: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter Item{i + 1}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int intvalue))
                {
                    items.Add(intvalue);
                } else if(double.TryParse(input,out double doublevalue))
                {
                    items.Add(doublevalue);
                }else if(bool.TryParse(input,out bool boolvalue))
                {
                    items.Add(boolvalue);
                }else if (string.IsNullOrEmpty(input))
                {
                    items.Add(null);
                }
                else
                {
                    items.Add(input);
                }
            }
        }
        public void DisplayItems()
        {
            Console.WriteLine("Items in the collection:" + string.Join(",", items.ToArray()).Replace(", ,",", null"));
            
        }
    }
}
