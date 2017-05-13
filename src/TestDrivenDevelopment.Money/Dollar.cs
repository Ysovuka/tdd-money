using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public int amount = 0;

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public bool equals(Object obj)
        {
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }
    }
}
