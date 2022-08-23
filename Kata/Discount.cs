using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public abstract class Discount
    {
        public abstract decimal discountPercentage { get; set; }
        public abstract DiscountOrderEnum orderEnum { get; set; }
    }
}
