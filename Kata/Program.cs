using System;

namespace Kata
{
    class Hello
    {
        static void Main(string[] args)
        {
            Product x = new("sample", 12345, 20.25m);
            TaxCalculater.CurrentTax = 0.20m;
            decimal y = TaxCalculater.PriceAfterTax(x);
            Console.WriteLine(y);
            y = TaxCalculater.PriceAfterTax(x , .22m);
            Console.WriteLine(y);
        }
    }
}

