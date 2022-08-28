using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{

    public interface IDiscount
    {
        public decimal DiscountAmount(decimal price);
        public bool CanApply(long upc);
        public decimal DiscountPercentage { get; set; }
        public DiscountOrderEnum OrderEnum { get; set; }
    }
}
