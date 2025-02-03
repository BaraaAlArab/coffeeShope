using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class OrderManager
    {
        private List<string> orders;
        public OrderManager() 
        {
            orders = new List<string>();
        
        }
        public void AddOrder(string order)
        {
            orders.Add(order);
            Console.WriteLine($"Your Order {order} has been added");
        }
        public void RemoveOrder(string order)
        {

            
            if (orders.Contains(order))
            {
                orders.Remove(order);
                Console.WriteLine($"Your order '{order}' has been removed ");
            }
            else 
            { 
                Console.WriteLine($"Your oder is not found '{order}'"); 
            }
        }
        public void Displayorder()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("No orders yet");
            }
            else
            {
                Console.WriteLine("Current orders are:  "+ string.Join(",", orders));
            }
        }

    }
}
