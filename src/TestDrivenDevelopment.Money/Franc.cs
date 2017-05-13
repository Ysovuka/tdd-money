using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Franc
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        private int amount = 0;

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Franc dollar = (Franc)obj;
            return amount == dollar.amount;
        }
    }
}
