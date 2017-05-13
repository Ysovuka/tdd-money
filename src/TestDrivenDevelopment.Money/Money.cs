using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Money
    {
        protected int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && currency.Equals(money.currency);
        }

        public static Money dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public string Currency()
        {
            return currency;
        }

        public override string ToString()
        {
            return $"{amount} {currency}";
        }

    }
}
