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

        public decimal PriceAfterTax(decimal Price)
        {
            decimal FinalPrice = Price + (Price * CurrentTax);
            FinalPrice = decimal.Round(FinalPrice, 2, MidpointRounding.AwayFromZero);
            return FinalPrice;
        }
        public decimal PriceAfterTax(decimal Price, decimal tax)
        {
            decimal FinalPrice = Price + (Price * tax);
            FinalPrice = decimal.Round(FinalPrice, 2, MidpointRounding.AwayFromZero);
            return FinalPrice ;
        }

    }
}
