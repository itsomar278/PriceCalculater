using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class TaxCalculater
    {
        public TaxCalculater(decimal currentTax)
        {
            CurrentTax = currentTax;
        }
        public decimal CurrentTax { get; }

        public decimal TaxAmount(decimal Price)
        {
            decimal taxAmount =  (Price * CurrentTax);
            taxAmount = decimal.Round(taxAmount, 2, MidpointRounding.AwayFromZero);
            return taxAmount ;
        }
        public decimal TaxAmount(decimal Price, decimal tax)
        {
            decimal taxAmount = (Price * tax);
            taxAmount = decimal.Round(taxAmount, 2, MidpointRounding.AwayFromZero);
            return taxAmount;
        }

    }
}
