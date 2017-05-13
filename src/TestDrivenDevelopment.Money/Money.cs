using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public abstract class Money
    {
        protected int amount;

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && this.GetType() == obj.GetType();
        }

        public static Money dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money franc(int amount)
        {
            return new Franc(amount);
        }

        public abstract Money Times(int multiplier);
    }
}
