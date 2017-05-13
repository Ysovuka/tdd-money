using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Money
{
    public class Bank
    {
        private IDictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) return 1;

            rates.TryGetValue(new Pair(from, to), out int rate);
            return rate;
        }

        public void addRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }
    }
}
