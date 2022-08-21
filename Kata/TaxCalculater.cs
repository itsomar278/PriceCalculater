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

        public void TaxApplier(Product product)
        {
            decimal taxAmount =  (product.price.basePrice * CurrentTax);
            taxAmount = decimal.Round(taxAmount, 2, MidpointRounding.AwayFromZero);
            product.price.TaxAmount = taxAmount; 

        }
        public void TaxApplier(Product product, decimal tax)
        {
            decimal taxAmount = (product.price.basePrice * tax);
            taxAmount = decimal.Round(taxAmount, 2, MidpointRounding.AwayFromZero);
            product.price.TaxAmount =  taxAmount;
        }

    }
}
