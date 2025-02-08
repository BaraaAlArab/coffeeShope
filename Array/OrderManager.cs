using System;
using System.Collections.Generic;

namespace OrderSystem
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
            if (string.IsNullOrWhiteSpace(order))
            {
                Console.WriteLine("\n Order name cannot be empty.");
                return;
            }

            orders.Add(order);
            Console.WriteLine($"Order '{order}' has been added.");
        }

        public void RemoveOrder(string order)
        {
            if (string.IsNullOrWhiteSpace(order))
            {
                Console.WriteLine("\n Please enter a valid order name.");
                return;
            }

            var match = orders.Find(x => x.Equals(order, StringComparison.OrdinalIgnoreCase));

            if (match != null)
            {
                orders.Remove(match);
                Console.WriteLine($"Your order '{order}' has been removed.");
            }
            else
            {
                Console.WriteLine($" Order '{order}' not found.");
            }
        }

        public void DisplayOrder()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine(" No orders yet.");
            }
            else
            {
                Console.WriteLine(" Current orders: " + string.Join(", ", orders));
            }
        }
    }
}
