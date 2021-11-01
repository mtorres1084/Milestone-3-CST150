using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Miguel Torres Perez
// CST-150

namespace Milestone3
{
    class InventoryItem
    {
        public string Flavor { get; private set; }
        public double Price { get; private set; }
        public int QuantityInStock { get; private set; }
        public string Description { get; private set; }
        public int ItemId { get; }
        public int QuantityOrdered { get; set; } = 0;
        private static int CountForId = 1;

        // Inventory item to add new item

        public InventoryItem(string flavor, double price, int quantity, string description)
        {
            this.Flavor = flavor;
            this.Price = price;
            this.QuantityInStock = quantity;
            this.Description = description;
            ItemId = CountForId;
            CountForId++;
        }
        
        // adding item to inventory

        public void AddItem(int amount)
        {
            QuantityInStock += amount;
        }

        // removing an item from inventory

        public void RemoveItem(int amount)
        {
            QuantityOrdered -= amount;
        }

        // Display to console configuration

        public new string ToString()
        {
            return "Flavor: " + Flavor + " Quantity in stock currently: " + QuantityInStock + " Item description: " + Description + " $" + Price;
        }
    }
}
