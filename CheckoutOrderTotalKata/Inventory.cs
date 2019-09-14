using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutOrderTotalKata
{
    public class Inventory
    {
        public List<Item> Items { get; set; }

        public Inventory()
        {
            Items = new List<Item> { new Item { Name = "meat", Price = 2.89m } };
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
