using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Kata
{
    public class PriceCalculater
    {
        public PriceCalculater(List<IDiscount> discounts, CombiningMethodEnum combiningEnum, CAP cap, List<Expense> expenses, TaxCalculater tax, Product product , RegionInfo region)
        {
            this.tax = tax;
            this.discounts = discounts;
            this.expenses = expenses;
            this.product = product;
            this.combiningEnum = combiningEnum;
            this.cap = cap;
            this.region = region; 
        }
        public List<Expense> expenses;
        public List<IDiscount> discounts;
        public TaxCalculater tax;
        public Product product;
        public CombiningMethodEnum combiningEnum;
        public CAP cap;
        public RegionInfo region;   
        public decimal UniversalDiscountAmount { get; set; }
        public decimal SelectiveDiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal RemainingPrice { get; set; }
        public decimal TaxedPrice { get; set; }
        public decimal ExpensesAmount { get; set; }
        public void ApplyBeforeTaxDiscounts()
        {
            RemainingPrice = product.price.BasePrice;
            var DiscountsBefore = discounts.Where(dis => dis.OrderEnum.Equals(DiscountOrderEnum.Before)).ToList();
            foreach (IDiscount dis in DiscountsBefore)
            {
                if (dis.CanApply(product.UPC))
                {
                    decimal discountAmount = dis.DiscountAmount(RemainingPrice);
                    if (combiningEnum.Equals(CombiningMethodEnum.Multiplicative))
                    {
                        RemainingPrice = RemainingPrice - discountAmount;
                    }
                    if (dis.GetType() == typeof(UniversalDiscount))
                    {
                        UniversalDiscountAmount += discountAmount;
                    }
                    else
                    {
                        SelectiveDiscountAmount += discountAmount;
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
            var DiscountsAfter = discounts.Where(dis => dis.OrderEnum.Equals(DiscountOrderEnum.After)).ToList();
            foreach (IDiscount dis in DiscountsAfter)
            {
                if (dis.CanApply(product.UPC))
                {
                    decimal discountAcount = dis.DiscountAmount(RemainingPrice);
                    if (combiningEnum.Equals(CombiningMethodEnum.Multiplicative))
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
                ExpensesAmount += expense.ExpenseAmount(product.price.BasePrice);
            }
        }
        public String FinalPrice()
        {
            ApplyBeforeTaxDiscounts();
            TaxApply();
            ApplyAfterTaxDiscounts();
            decimal TotalDiscounts = UniversalDiscountAmount + SelectiveDiscountAmount;
            if(TotalDiscounts>cap.CAPAmount(product.price.BasePrice ))
                {
                TotalDiscounts = cap.CAPAmount(product.price.BasePrice);
                }
            decimal total = product.price.BasePrice + TaxAmount - TotalDiscounts;
            total = decimal.Round(total, 2, MidpointRounding.AwayFromZero);
            ExpensesApply();
            StringBuilder sb = new StringBuilder();
            sb.Append(total.ToString());
            sb.Append($" {region.ISOCurrencySymbol}");
            return sb.ToString();
        }
    }
}
