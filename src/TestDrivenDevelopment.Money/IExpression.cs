using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
    }
}
