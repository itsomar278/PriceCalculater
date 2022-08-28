using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Price
    {
        public Price(decimal price)
        {
            if (!price.IsPrice())
            {
                throw new ArgumentException("check the product data entered ");
            }
            BasePrice = price;
        }
        public decimal BasePrice { get; private set; }
    }
}
