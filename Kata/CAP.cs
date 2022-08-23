using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class CAP
    {
        public CAP (decimal amount , RelativityEnum relativityEnum)
        {
            this.amount=amount;
            this.relativityEnum=relativityEnum;
        }

        public decimal CAPAmount(decimal price)
        {
            if(relativityEnum.Equals(RelativityEnum.Absolute))
                {
                return amount;
                }
            else
            {
                decimal value = amount * price; 
                value = decimal.Round(value, 2, MidpointRounding.AwayFromZero);
                return value;
            }
        }
        public decimal amount { get; set; }
        public RelativityEnum relativityEnum { get; set; }
    }
}
