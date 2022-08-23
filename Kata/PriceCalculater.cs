using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class PriceCalculater
    {
        public PriceCalculater(List<Discount> discounts, CombiningEnum combiningEnum, CAP cap, List<Expense> expenses, TaxCalculater tax, Product product)
        {
            this.tax = tax;
            this.discounts = discounts;
            this.expenses = expenses;
            this.product = product;
            this.combiningEnum = combiningEnum;
            this.cap = cap;
        }
        public List<Expense> expenses;
        public List<Discount> discounts;
        public TaxCalculater tax;
        public Product product;
        public CombiningEnum combiningEnum;
        public CAP cap;
        public decimal UniversalDiscountAmount { get; set; }
        public decimal SelectiveDiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal RemainingPrice { get; set; }
        public decimal TaxedPrice { get; set; }
        public decimal ExpensesAmount { get; set; }
        public void ApplyBeforeTaxDiscounts()
        {
            RemainingPrice = product.price.basePrice;
            var DiscountsBefore = discounts.Where(dis => dis.orderEnum.Equals(DiscountOrderEnum.before)).ToList();
            foreach (Idiscount dis in DiscountsBefore)
            {
                if (dis.CanApply(product.UPC))
                {
                    decimal discountAcount = dis.DiscountAmount(RemainingPrice);
                    if (combiningEnum.Equals(CombiningEnum.Multiplicative))
                    {
                        RemainingPrice = RemainingPrice - discountAcount;
                    }
                    if (dis.GetType() == typeof(UniversalDiscount))
                    {
                        UniversalDiscountAmount += discountAcount;
                    }
                    else
                    {
                        SelectiveDiscountAmount += discountAcount;
                    }
                }
            }
        }
        public void TaxApply()
        {
            TaxAmount = tax.TaxAmount(RemainingPrice);
        }
        public void ApplyAfterTaxDiscounts()
        {
            var DiscountsAfter = discounts.Where(dis => dis.orderEnum.Equals(DiscountOrderEnum.after)).ToList();
            foreach (Idiscount dis in DiscountsAfter)
            {
                if (dis.CanApply(product.UPC))
                {
                    decimal discountAcount = dis.DiscountAmount(RemainingPrice);
                    if (combiningEnum.Equals(CombiningEnum.Multiplicative))
                        {
                        RemainingPrice = RemainingPrice - discountAcount;
                        }
                   
                    if (dis.GetType() == typeof(UniversalDiscount))
                    {
                        UniversalDiscountAmount += discountAcount;
                    }
                    else
                    {
                        SelectiveDiscountAmount += discountAcount;
                    }
                }
            }
        }
        public void ExpensesApply()
        {
            foreach ( Expense expense in expenses)
            {
                ExpensesAmount += expense.ExpenseAmount(product.price.basePrice);
            }
        }
     
        public decimal FinalPrice()
        {
            ApplyBeforeTaxDiscounts();
            TaxApply();
            ApplyAfterTaxDiscounts();
            decimal TotalDiscounts = UniversalDiscountAmount + SelectiveDiscountAmount;
            if(TotalDiscounts>cap.CAPAmount(product.price.basePrice ))
                {
                TotalDiscounts = cap.CAPAmount(product.price.basePrice);
                }
            ExpensesApply();
            return (product.price.basePrice - TotalDiscounts + TaxAmount + ExpensesAmount);
        }
    }
}
