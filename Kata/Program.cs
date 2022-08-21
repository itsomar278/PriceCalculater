using System;

namespace Kata
{
    class Hello
    {
        static void Main(string[] args)
        {
            // filling dummy data 
            Product A = new("Sample1", 11345, 20.25m);
            Product B = new("Sample2", 12345, 15.00M);
            Product C = new("Sample3", 13345, 100M);
            Product D = new("Sample4", 14345, 50M);
            List<Product> products = new  List<Product>() ; 
            products.Add(A);
            products.Add(B);
            products.Add(C);
            products.Add(D);

            // applying taxes and discounts 
            TaxCalculater tax = new TaxCalculater(0.20M);
            DiscountCalculater discount = new DiscountCalculater(0.15M);
            foreach(Product product in products)
            {
                decimal finalPrice;
                tax.TaxApplier(product);
                discount.DiscountApplier(product);
               
                Console.Write($"tax amount : {product.price.TaxAmount}");
                Console.Write(" ");
                Console.Write(product.price.DiscountAmount);
                Console.Write(" ");
                Console.Write(product.price.FinalPrice());
                Console.Write("\n");
            }


        }
    }
}

