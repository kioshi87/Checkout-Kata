using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutOrderTotalKata
{
    public class Checkout
    {
        private Inventory _inventory;

        public Checkout()
        {
            _inventory = new Inventory(); 
        }

        public decimal ItemScan(string item)
        {
           var itemInInventory = _inventory.Items.Where(_ => _.Name == item).FirstOrDefault();
           return itemInInventory.Price;
        }

        
    }
}
