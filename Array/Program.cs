﻿using OrderSystem;
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


            OrderManager orderManager = new OrderManager();
            while (true)
            {
                Console.WriteLine("\n===============================");
                Console.WriteLine("          ORDER MENU           ");
                Console.WriteLine("===============================");
                
                Console.WriteLine("1. Add Order");
                Console.WriteLine("2. Remove Order");
                Console.WriteLine("3. View Orders");
                Console.WriteLine("4. Exit");

                Console.WriteLine("choose an option");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                            Console.Write("Enter your order name");
                        string newOrder = Console.ReadLine();   
                        orderManager.AddOrder(newOrder);
                        break;

                    case "2":
                        Console.Write("Remove your order");
                        string RemoveOrder = Console.ReadLine();
                        orderManager.RemoveOrder(RemoveOrder);
                        break;
                    
                    case "3":
                        
                        orderManager.DisplayOrder();
                        break;

                    case "4":
                        Console.Write("Exit Program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}