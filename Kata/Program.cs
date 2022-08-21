using System;

namespace Kata
{
    class Hello
    {
        static void Main(string[] args)
        {
            Product x = new("Sample", 12345, 20.25m);
            TaxCalculater tax = new TaxCalculater(0.20M);
         
        }
    }
}

