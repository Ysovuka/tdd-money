using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Sum : IExpression
    {
        public Sum(IExpression augend, IExpression addend)
        {
            this.addend = addend;
            this.augend = augend;
        }

        public IExpression augend;
        public IExpression addend;

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Reduce(bank, to).Amount + addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public IExpression Plus(IExpression addend)
        {
            return null;
        }
    }
}
