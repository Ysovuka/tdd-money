﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestDrivenDevelopment.Money.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void testMultiplication()
        {
            Money five = Money.dollar(5);
            Assert.Equal(Money.dollar(10), five.Times(2));
            Assert.Equal(Money.dollar(15), five.Times(3));
        }

        [Fact]
        public void testEquality()
        {
            Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.False(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.False(Money.franc(5).Equals(Money.dollar(5)));
        }

        [Fact]
        public void testCurrency()
        {
            Assert.Equal("USD", Money.dollar(1).Currency());
            Assert.Equal("CHF", Money.franc(1).Currency());
        }

        [Fact]
        public void testSimpleAddition()
        {
            Money five = Money.dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.Equal(Money.dollar(10), reduced);
        }

        [Fact]
        public void testPlusReturnsSum()
        {
            Money five = Money.dollar(5);
            IExpression result = five.Plus(five);
            Sum sum = (Sum)result;
            Assert.Equal(five, sum.augend);
            Assert.Equal(five, sum.addend);
        }

        [Fact]
        public void testReducedSum()
        {
            IExpression sum = new Sum(Money.dollar(3), Money.dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.dollar(7), result);
        }

        [Fact]
        public void testReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.dollar(1), "USD");
            Assert.Equal(Money.dollar(1), result);
        }

        [Fact]
        public void testReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.franc(2), "USD");
            Assert.Equal(Money.dollar(1), result);
        }

        [Fact]
        public void testIdentityRate()
        {
            Assert.Equal(1, new Bank().Rate("USD", "USD"));
        }

        [Fact]
        public void testMixedAddition()
        {
            IExpression fiveBucks = Money.dollar(5);
            IExpression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.Equal(Money.dollar(10), result);
        }

        [Fact]
        public void testSumPlusMoney()
        {
            IExpression fiveBucks = Money.dollar(5);
            IExpression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            IExpression sum = new Sum(fiveBucks, tenFrancs).Plus(fiveBucks);
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.dollar(15), result);
        }

        [Fact]
        public void testSumTimes()
        {
            IExpression fiveBucks = Money.dollar(5);
            IExpression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            IExpression sum = new Sum(fiveBucks, tenFrancs).Times(2);
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.dollar(20), result);
        }
    }
}
