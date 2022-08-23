using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class UniversalDiscount : Discount ,Idiscount
    {
        public UniversalDiscount(decimal discountPercentage , DiscountOrderEnum orderEnum)
        {
            this.discountPercentage = discountPercentage;
            this.orderEnum = orderEnum;
        }
        public override DiscountOrderEnum orderEnum { get; set; }
        public override decimal discountPercentage { get;  set; }
        public decimal DiscountAmount(decimal price )
        {
                decimal discountAmount = (price * discountPercentage);
                discountAmount = decimal.Round(discountAmount, 4, MidpointRounding.AwayFromZero);
                return discountAmount;
        }
        public bool CanApply(long upc)
        {
            return true;
        }
    }
}

 
