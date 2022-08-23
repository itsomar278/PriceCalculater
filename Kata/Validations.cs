using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal static class Validations
    {
        public static bool IsUPC (this long upc )
        {
           
            if(upc.ToString().Length != 5 )
            {
                return false;
            }
            if (upc < 0 )
            { 
                return false;
            }
            return true; 
        }
        public static bool IsPrice (this decimal price )
        {
            if(price == 0 || price < 0 )
            {
                return false; 
            }
            return true; 

        }
        public static bool IsProductName(this string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            return true;
        }
    }
}
