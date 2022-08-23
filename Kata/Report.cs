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
          return($" {price.UniversalDiscountAmount + price.SelectiveDiscountAmount} $ amount which was deduced");
        }
        public static string ExpensesReport(this PriceCalculater price)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Expense expense in price.expenses)
            {

                 sb.AppendLine($"{expense.Description} : {expense.ExpenseAmount(price.product.price.basePrice)} $");
            }
            return sb.ToString() ;
        }
    }
}
