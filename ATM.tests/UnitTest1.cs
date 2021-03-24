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

        // Test fails as default state is not always accesable

        //[Fact]
        //public void ViewBalance_returns_0_before_change()
        //{
        //    // arange
        //    // hopefully balance is default

        //    // act
        //    decimal result = Program.ViewBalance();

        //    // assert
        //    Assert.Equal(0m, result);
        //}

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

        [Fact]
        public void Withdraw_returns_a_decimal()
        {
            // arange
            decimal input = 0m;

            // act
            decimal result = Program.Withdraw(input);

            // assert
            Assert.IsType(input.GetType(), result);
        }

        [Fact]
        public void Withdraw_returns_0_when_withdrawing_with_no_balance()
        {
            // arange
            decimal amount = 10m;
            Program.Balance = 0m;

            // act
            decimal result = Program.Withdraw(amount);

            // assert
            Assert.Equal(0M, result);
        }

        [Fact]
        public void Withdraw_returns_difference_when_withdrawing_more_than_balance()
        {
            // arange
            decimal amount = 10m;
            Program.Balance = 5m;

            // act
            decimal result = Program.Withdraw(amount);

            // assert
            Assert.Equal(5m, result);
        }

        [Fact]
        public void Withdraw_returns_0_when_withdrawing_a_negative_balance()
        {
            // arange
            decimal amount = -10m;

            // act
            decimal result = Program.Withdraw(amount);

            // assert
            Assert.Equal(0m, result);
        }
    }
}
