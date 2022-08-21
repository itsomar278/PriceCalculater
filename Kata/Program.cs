using System;

namespace Kata
{
    class Hello
    {
        static void Main(string[] args)
        {
            Product x = new("Sample", 12345, 20.25m);
            TaxCalculater tax = new TaxCalculater(0.20M);
            decimal y = tax.PriceAfterTax(x.price.basePrice);
            Console.WriteLine(y);
            y = tax.PriceAfterTax(x.price.basePrice, .21m);
            Console.WriteLine(y);
        }
    }
}

