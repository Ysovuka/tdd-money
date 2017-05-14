using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public interface IExpression
    {
        IExpression Plus(IExpression eddend);
        IExpression Times(int multiplier);
        Money Reduce(Bank bank, string to);
    }
}
