using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Money : IExpression
    {
        public int Amount { get; }
        protected string currency;

        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this.currency = currency;
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && currency.Equals(money.currency);
        }

        public static Money dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public IExpression Times(int multiplier)
        {
            return new Money(Amount * multiplier, currency);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(currency, to);
            return new Money(Amount / rate, to);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public string Currency()
        {
            return currency;
        }

        public override string ToString()
        {
            return $"{Amount} {currency}";
        }

    }
}
