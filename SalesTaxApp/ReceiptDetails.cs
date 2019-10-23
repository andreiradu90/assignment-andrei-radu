using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxApp
{
    public class ReceiptDetails
    {
        public List<ItemReceipt> ReceiptItems { get; }
        public decimal SalesTax { get; private set; }
        public decimal Total { get ; private set ; }

        public ReceiptDetails()
        {
            ReceiptItems = new List<ItemReceipt>();
            SalesTax = 0;
            Total = 0;
        }
        public void AddItem(Item item, decimal itemTax, decimal itemTotalPrice)
        {
            ReceiptItems.Add(new ItemReceipt(item, itemTotalPrice));
            SalesTax += itemTax;
            Total += itemTax + item.BasePrice;
        }
    }
}
