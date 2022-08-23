using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Expense
    {
        public Expense(string description, ExpenseTypeEnum expenseTypeEnum, decimal amount)
        {
            Description = description;
            Amount = amount;
            this.expenseTypeEnum = expenseTypeEnum;
        }
        public decimal ExpenseAmount(decimal price)
        {
            if(expenseTypeEnum.Equals(ExpenseTypeEnum.Absolute))
                {
                return Amount;
                }
            else
            {
                decimal value = price * Amount;
                value = decimal.Round(value, 2, MidpointRounding.AwayFromZero);
                return value;

            }
        }
        public String Description { get; set; }
        public decimal Amount { get; set; }
        public ExpenseTypeEnum expenseTypeEnum { get; set; }
    }
}
