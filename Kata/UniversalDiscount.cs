using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class UniversalDiscount : IDiscount
    {
        public UniversalDiscount(decimal discountPercentage , DiscountOrderEnum orderEnum)
        {
            this.DiscountPercentage = discountPercentage;
            this.OrderEnum = orderEnum;
        }
        public DiscountOrderEnum OrderEnum { get; set; }
        public decimal DiscountPercentage { get;  set; }
        public decimal DiscountAmount(decimal price )
        {
                decimal discountAmount = (price * DiscountPercentage);
                discountAmount = decimal.Round(discountAmount, 4, MidpointRounding.AwayFromZero);
                return discountAmount;
        }
        public bool CanApply(long upc)
        {
            return true;
        }
    }
}

 
