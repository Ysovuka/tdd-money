using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            return Money.dollar(10);
        }
    }
}
