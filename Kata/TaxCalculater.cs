using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal static class TaxCalculater
    {
        public static decimal CurrentTax { get; set; }

        public static decimal PriceAfterTax(Product x )
        {
            decimal FinalPrice = x.Price + (x.Price * CurrentTax);
            FinalPrice = decimal.Round(FinalPrice, 2, MidpointRounding.AwayFromZero);
            return FinalPrice;
        }

        public static decimal PriceAfterTax(Product x, decimal tax)
        {
            decimal FinalPrice = x.Price + (x.Price * tax);
            FinalPrice = decimal.Round(FinalPrice, 2, MidpointRounding.AwayFromZero);
            return FinalPrice ;
        }


    }
}
