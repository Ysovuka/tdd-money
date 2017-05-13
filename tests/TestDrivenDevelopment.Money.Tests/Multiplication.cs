using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestDrivenDevelopment.Money.Tests
{
    public class Multiplication
    {
        [Fact]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.Equal(10, five.amount);
        }
    }
}
