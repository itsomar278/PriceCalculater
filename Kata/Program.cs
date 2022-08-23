using System;

namespace Kata
{
    class Hello
    {
        static void Main(string[] args)
        {
            // filling dummy data 
            Product A = new("Sample1", 12345, 20.25m);
            Product B = new("Sample2", 12111, 15.00M);
            Product C = new("Sample3", 13345, 100M);
            Product D = new("Sample4", 14345, 50M);
            List<Product> products = new  List<Product>() ; 
            products.Add(A);
            products.Add(B);
            products.Add(C);
            products.Add(D);
            // taxes 
            TaxCalculater tax = new TaxCalculater(0.20M);
            // discounts
            UniversalDiscount discount = new UniversalDiscount(0.15M ,(DiscountOrderEnum.after));
            SelectiveDiscount discount2 = new SelectiveDiscount(12345,0.07M, (DiscountOrderEnum.after));
            List<Discount> discounts = new List<Discount>() ;
            discounts.Add(discount);
            discounts.Add(discount2);
            //expenses 
            Expense expense = new Expense("packaging", ExpenseTypeEnum.relative, 0.01M);
            Expense expense2 = new Expense("delivery", ExpenseTypeEnum.Absolute, 2.2M);
            List<Expense> expenses = new List<Expense>() ;
            expenses.Add(expense);
            expenses.Add(expense2);


            // proccessing discount and taxes 
            PriceCalculater price = new PriceCalculater(discounts,expenses, tax, A);
            Console.WriteLine(price.FinalPrice());
            Console.WriteLine(price.DiscountReport());
            Console.WriteLine(price.ExpensesReport());
        }
    }
}
   
