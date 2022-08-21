using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class Report
    {
        public static string DiscountReport(this Product product)
        {
          return($"$ {product.price.DiscountAmount} amount which was deduced");
        }
    }
}
