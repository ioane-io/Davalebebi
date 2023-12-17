using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Inventory
    {
        private Dictionary<string, Item> items;

        public Inventory()
        {
            items = new Dictionary<string, Item>();
        }
        public void DictionaryAddItem(string key, Item item)
        {
            if (items.ContainsKey(key))
            {
                throw new ArgumentException("Item already exists.");
            }

            items[key] = item;
        }
        public Item GetItem(string key)
        {
            if (items.ContainsKey(key))
            {
                return items[key];
            }

            throw new KeyNotFoundException("Item not found");
        }
        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var item in items.Values)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }
    }
}