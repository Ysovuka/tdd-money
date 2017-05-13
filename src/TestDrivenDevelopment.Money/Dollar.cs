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

        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}
