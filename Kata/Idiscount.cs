using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
   
    public interface Idiscount
    {
        public decimal DiscountAmount(decimal price );
        public bool CanApply(long upc);
    }

    
}
 