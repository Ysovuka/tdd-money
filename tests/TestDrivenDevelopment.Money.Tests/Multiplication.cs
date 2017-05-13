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
            Dollar product = five.times(2);
            Assert.Equal(10, product.amount);
            product = five.times(3);
            Assert.Equal(15, product.amount);
        }
    }
}
