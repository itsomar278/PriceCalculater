using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class DiscountCalculater
    {
        public DiscountCalculater(decimal discountPercentage)
        {
            this.discountPercentage = discountPercentage;
        }

        public decimal discountPercentage { get; private set; }
        public decimal DiscountAmount(decimal price)
        {
            decimal discountAmount =  (price * discountPercentage);
            discountAmount = decimal.Round(discountAmount, 2, MidpointRounding.AwayFromZero);
            return (discountAmount) ;
        }
    }

}
