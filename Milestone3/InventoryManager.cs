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
    class InventoryManager
    {
        InventoryItem[] currentInventory = new InventoryItem[10];
        private int inventoryEndIndex = 0;

        // Fill array with beginning stock

        public InventoryManager()
        {
            currentInventory[0] = new InventoryItem("Vanilla", 1.49, 20, "Vanilla Ice Cream");
            currentInventory[1] = new InventoryItem("Chocolate", 1.49, 10, "Chocolate Ice Cream");
            currentInventory[2] = new InventoryItem("Cherry", 1.49, 13, "Cherry Ice Cream");
            currentInventory[3] = new InventoryItem("Caramel", 1.49, 2, "Caramel Ice Cream");
            currentInventory[4] = new InventoryItem("Coffee", 1.49, 3, "Coffee Ice Cream");
            currentInventory[5] = new InventoryItem("Peanut Butter", 1.49, 25, "Peanut Butter Ice Cream");
            inventoryEndIndex = 6;
        }

        // Add new item to array

        public void AddItem(string flavor, double price, int quantity, string description)
        {
            currentInventory[inventoryEndIndex] = new InventoryItem(flavor, price, quantity, description);
            inventoryEndIndex++;
        }

        // remove an item from array

        public void RemoveItem(int index)
        {
            for (int i = 0; (i + index) <= (currentInventory.Length - 1); i++)
            {
                if((index + i) == (currentInventory.Length - 1))
                {
                    currentInventory[index + i] = null;
                }else
                {
                    currentInventory[index + i] = currentInventory[index + i + 1];
                }
            }
            inventoryEndIndex--;
        }

        // restock an item in the array

        public void RestockItem(int index, int quantity)
        {
            currentInventory[index].AddItem(quantity);
        }

        // display all current inventory

        public void DisplayItems()
        {
            for(int i = 0; i < inventoryEndIndex; i++)
            {
                Console.WriteLine(currentInventory[i].ToString());
            }
        }

        // display a single inventory item for search feature 

        public string DisplaySearchedItem(int index)
        {
            return currentInventory[index].ToString();
        }

        // Search either by flavor or by quantity in stock

        public int SearchInventory(string searchingFor, string lookingFor)
        {
            switch (searchingFor)
            {
                case "flavor" :
                    for(int index = 0; index < currentInventory.Length; index++)
                    {
                        if(currentInventory[index].Flavor == lookingFor)
                        {
                            return index;
                        }
                        if(index == currentInventory.Length - 1)
                        {
                            return -1;
                        }
                    }
                    break;
                case "quantity":
                    for(int index = 0; index < currentInventory.Length; index++)
                    {
                        if(currentInventory[index].QuantityInStock == int.Parse(lookingFor))
                        {
                            return index;
                        }
                        if(index == currentInventory.Length - 1)
                        {
                            return -1;
                        }
                    }
                    break;
            }
            return -1;
        }
    }
}
