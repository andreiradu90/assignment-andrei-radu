using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxApp
{
    public class ItemReceipt
    {
        public Item BaseItem { get; }
        public decimal PriceIncludingSalesTax { get ; private set; }

        public ItemReceipt(Item BaseItem, decimal PriceIncludingSalesTax)
        {
            this.BaseItem = BaseItem;
            this.PriceIncludingSalesTax = PriceIncludingSalesTax;
        }
    }
}
