using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxApp
{
    public enum Category
    {
        Magazines = 1,
        Food = 2,
        Electronics = 4,
        NotTaxed = Magazines | Food | Electronics,
        Other = 8
    }
    static class CategoryExtensions
    {
        public static bool IsTaxed(this Category category)
        {
            return (category & Category.NotTaxed) == 0;
        }
    }
}
