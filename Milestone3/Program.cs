using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Miguel Torres Perez
// CST-150
// Milestone 3

namespace Milestone3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new inventory manager and test the add, remove, restock, display items and search by flavor and quantity
            // displaying all in console

            InventoryManager inventory = new InventoryManager();
            Console.WriteLine("Your current inventory: ");
            inventory.DisplayItems();
            inventory.AddItem("Mint", 1.49, 6, "Mint Ice Cream");
            Console.WriteLine("\r\nInventory after adding Mint Ice Cream:");
            inventory.DisplayItems();
            inventory.RemoveItem(1);
            Console.WriteLine("\r\nYour inventory after removing Chocolate Ice Cream: ");
            inventory.DisplayItems();
            Console.WriteLine("\r\nYour inventory after restocking 5 Caramel Ice Cream: ");
            inventory.RestockItem(2, 5);
            inventory.DisplayItems();
            Console.WriteLine("\r\nSearching inventory for Peanut Butter: ");
            Console.WriteLine(inventory.DisplaySearchedItem(inventory.SearchInventory("flavor", "Peanut Butter")));
            Console.WriteLine("\r\nSearching for any items with a quantity of 13: ");
            Console.WriteLine(inventory.DisplaySearchedItem(inventory.SearchInventory("quantity", "13")));
            Console.ReadLine();
        }
    }
}
