using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class Product
    {
        public Product(String Name , long UPC , decimal Price)
        {
            if(!Name.IsProductName() ||!UPC.IsUPC() ||!Price.IsPrice() )
            {
                throw new ArgumentException("check the product data entered "); 
            }
            _Name = Name;
            _UPC = UPC;
            _Price = Price;

        }
     
        public string _Name;
        public long _UPC;
        public decimal _Price; 
        public decimal Price
        {
            get 
            { 
                return _Price;
            }
            private set 
            {
                if (value.IsPrice())
                {
                    _Price = value;
                }
                throw new ArgumentException("invalid price"); 
            }
        }
        public long UPC
        {
            get
            {
                return _UPC;
            }
            private set
            {
                if (value.IsUPC())
                {
                    _UPC = value;
                }
                throw new ArgumentException("UPC is invalid");
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
           private set
            {
               if (value.IsProductName())
                {
                    _Name = value;  
                }

            }

        }

    }
}
