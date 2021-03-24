using System;
using Xunit;
using ATM;

namespace ATM.tests
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalance_returns_balance_after_change()
        {
            // arange
            Program.Balance = 10m;

            // act
            decimal result = Program.ViewBalance();

            // assert
            Assert.Equal(10m, result);
        }

        [Fact]
        public void ViewBalance_returns_0_before_change()
        {
            // arange
            // hopefully balance is default

            // act
            decimal result = Program.ViewBalance();

            // assert
            Assert.Equal(0m, result);
        }

        [Fact]
        public void ViewBalance_returns_same_value_as_balance()
        {
            // arange
            Program.Balance = 10m;

            // act
            decimal result = Program.ViewBalance();

            // assert
            decimal expected = Program.Balance;
            Assert.Equal(expected, result);
        }

    }
}
