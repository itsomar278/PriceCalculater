using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class Report
    {
        public static string DiscountReport(this PriceCalculater price)
        {
            decimal totalDiscounts = price.UniversalDiscountAmount + price.SelectiveDiscountAmount;
            decimal  capAmount = price.cap.CAPAmount(price.product.price.basePrice);
            if (capAmount < totalDiscounts)
            {
                totalDiscounts = capAmount;
            }
          return($"{totalDiscounts} {price.region.ISOCurrencySymbol} was deduced from price");
        }
        public static string ExpensesReport(this PriceCalculater price)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Expense expense in price.expenses)
            {
                 sb.AppendLine($"{expense.Description} : {expense.ExpenseAmount(price.product.price.basePrice)  } {price.region.ISOCurrencySymbol}");
            }
            return sb.ToString() ;
        }
    }
}
