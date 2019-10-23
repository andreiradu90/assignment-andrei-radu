using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxApp
{
    public class SalesTaxCalculator
    {
        const decimal SalesTax = 15m;
        const decimal ImportTax = 10m;

        public static ReceiptDetails Process(params Item[] items)
        {
            ReceiptDetails receiptDetails = new ReceiptDetails();
            foreach(Item item in items)
            {
                decimal itemTax = GetItemTax(item);
                receiptDetails.AddItem(item, Math.Round(itemTax, 2), Math.Round(itemTax + item.BasePrice, 2));
            }
            return receiptDetails;
        }
        private static decimal GetItemTax(Item item)
        {
            decimal itemTax = 0;
            if (item.Category.IsTaxed())
            {
                itemTax += GetTaxValue(SalesTax, item.BasePrice);
            }
            if (item.Imported)
            {
                itemTax += GetTaxValue(ImportTax, item.BasePrice);
            }
            return itemTax;
        }
        private static decimal GetTaxValue(decimal tax, decimal baseValue)
        {
            return tax / 100 * baseValue;
        }
    }
}
