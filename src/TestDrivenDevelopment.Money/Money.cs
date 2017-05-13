using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Money
    {
        protected int amount;

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount;
        }
    }
}
