using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public interface IExpression
    {
        Money Reduce(string to);
    }
}
