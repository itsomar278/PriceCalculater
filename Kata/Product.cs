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
            this.Name = Name;
            this.UPC = UPC;
            price = new Price(Price);
        }
        public String Name;
        public string _Name
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
        public long UPC;
        public long _UPC
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
        public readonly Price price;        
    }
}
