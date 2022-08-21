using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Product
    {
        public Product(String Name , long UPC , decimal Price)
        {
            if(!UPC.IsUPC()||!Name.IsProductName()  )
            {
                throw new ArgumentException("check the product data entered "); 
            }
            Name = Name;
            UPC = UPC;
            price = new Price(Price);
            

        }
     
        public string Name
        {
            get
            {
                return Name;
            }
            private set
            {
                if (value.IsProductName())
                {
                    Name = value;
                }

            }

        }
        public long UPC
        {
            get
            {
                return UPC;
            }
            private set
            {
                if (value.IsUPC())
                {
                    UPC = value;
                }
                throw new ArgumentException("UPC is invalid");
            }
        }
        public Price price;        
    }
}
