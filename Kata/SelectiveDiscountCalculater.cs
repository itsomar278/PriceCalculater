using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class SelectiveDiscountCalculater : DiscountCalculater
    {
        public SelectiveDiscountCalculater(long upc , decimal discountPercentage) : base(discountPercentage)
        {
              this.upc = upc;
        }

        long upc { get; set; }

        override
            public void DiscountApplier(Product product )
        {
           
            if (upc == product.UPC)
            {
                decimal discountAmount = (product.price.basePrice * discountPercentage);
                discountAmount = decimal.Round(discountAmount, 2, MidpointRounding.AwayFromZero);

                product.price.SelectiveDiscountAmount = discountAmount;
            }
            // do nothing 
        }
    }
}
