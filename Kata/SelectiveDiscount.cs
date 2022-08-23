using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kata
{
    
    public class SelectiveDiscount :Discount ,Idiscount
    {
        public SelectiveDiscount(long upc , decimal discountPercentage , DiscountOrderEnum orderEnum) 
        {
            this.discountPercentage = discountPercentage;
            this.upc = upc;
            this.orderEnum = orderEnum;
        }
        public override decimal discountPercentage { get ; set; }
        public override DiscountOrderEnum orderEnum { get; set; }
        long upc { get; set; }

            public decimal DiscountAmount(decimal price )
        {
                decimal discountAmount = (price * discountPercentage);
                discountAmount = decimal.Round(discountAmount, 2, MidpointRounding.AwayFromZero);
                return discountAmount;
        }
        public bool CanApply(long upc)
        {
            if (upc == this.upc)
            {
                return true; 
            }
            return false;
        }
    }
}

    