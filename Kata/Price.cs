using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Price
    {
        public Price (decimal price )
        {
            if(!price.IsPrice())
            {
                throw new ArgumentException("check the product data entered ");

            }
            basePrice = price; 
        }

        public decimal basePrice { get; private set; }
        public decimal UniversalDiscountAmount { get;  set; }
        public decimal SelectiveDiscountAmount { get; set; }
        public decimal TaxAmount { get;  set; } 

        public decimal FinalPrice()
        {
            decimal finalPrice = (basePrice - UniversalDiscountAmount - SelectiveDiscountAmount) + TaxAmount;
            return finalPrice ;
        }


       
    }
}
