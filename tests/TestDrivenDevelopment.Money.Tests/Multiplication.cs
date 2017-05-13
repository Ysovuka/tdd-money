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
            Dollar product = five.Times(2);
            Assert.Equal(10, product.amount);
            product = five.Times(3);
            Assert.Equal(15, product.amount);
        }

        [Fact]
        public void testEquality()
        {
            Assert.True(new Dollar(5).equals(new Dollar(5)));
            Assert.False(new Dollar(5).equals(new Dollar(6)));
        }
    }
}
