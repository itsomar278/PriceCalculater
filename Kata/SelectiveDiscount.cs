using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kata
{
    
    public class SelectiveDiscount : IDiscount
    {
        public SelectiveDiscount(long upc ,decimal discountPercentage ,DiscountOrderEnum orderEnum) 
        {
            this.DiscountPercentage = discountPercentage;
            this.UPC = upc;
            this.OrderEnum = orderEnum;
        }
        public decimal DiscountPercentage { get ; set; }
        public DiscountOrderEnum OrderEnum { get; set; }
        long UPC { get; set; }
            public decimal DiscountAmount(decimal price )
        {
                decimal discountAmount = (price * DiscountPercentage);
                discountAmount = decimal.Round(discountAmount, 4, MidpointRounding.AwayFromZero);
                return discountAmount;
        }
        public bool CanApply(long upc)
        {
            if (upc == this.UPC)
            {
                return true; 
            }
            return false;
        }
    }
}

    