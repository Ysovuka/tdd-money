using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
            : base(amount, currency)
        {

        }

        public override Money Times(int multiplier)
        {
            return Money.dollar(amount * multiplier);
        }
    }
}
