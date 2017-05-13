using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Sum : IExpression
    {
        public Sum(Money augend, Money addend)
        {
            this.addend = addend;
            this.augend = augend;
        }

        public Money augend;
        public Money addend;

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Amount + addend.Amount;
            return new Money(amount, to);
        }
    }
}
