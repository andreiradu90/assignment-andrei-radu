using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxApp
{
    public class Item
    {
        public string ItemName { get; }
        public decimal BasePrice { get; }
        public Category Category { get; }
        public bool Imported { get; }

        public Item(string itemName, decimal basePrice, Category category, bool imported)
        {
            ItemName = itemName;
            BasePrice = basePrice;
            Category = category;
            Imported = imported;
        }

        public Item(string itemName, decimal basePrice) : this(itemName, basePrice, Category.Other, false) { }
        public Item(string itemName, decimal basePrice, Category category) : this(itemName, basePrice, category, false) { }
        public Item(string itemName, decimal basePrice, bool imported) : this(itemName, basePrice, Category.Other, imported) { }

    }
}
