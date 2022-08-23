using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Expense
    {
        public Expense(string description, RelativityEnum expenseTypeEnum, decimal amount)
        {
            Description = description;
            Amount = amount;
            this.expenseTypeEnum = expenseTypeEnum;
        }
        public decimal ExpenseAmount(decimal price)
        {
            if(expenseTypeEnum.Equals(RelativityEnum.Absolute))
                {
                return Amount;
                }
            else
            {
                decimal value = price * Amount;
                value = decimal.Round(value, 4, MidpointRounding.AwayFromZero);
                return value;
            }
        }
        public String Description { get; set; }
        public decimal Amount { get; set; }
        public RelativityEnum expenseTypeEnum { get; set; }
    }
}
