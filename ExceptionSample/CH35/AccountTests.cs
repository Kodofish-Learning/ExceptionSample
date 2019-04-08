using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace ErrorHandlerSample.CH35
{
    [TestFixture]
    public class AccountTest
    {
        [Test]
        public void Withdraw_Amount_biggest_than_balance_should_get_errorCode()
        {
            var account = new Account();
            Assert.Throws<NotEnoughMoneyException>(() => account.Withdraw(10));
        }


        [Test]
        public void Withdraw_Amount_smallest_than_balance_should_get_balance()
        {
            var account = new Account(100);
            var actual = account.Withdraw(10);
            var expected = 90m;

            actual.ShouldBe(expected);
        }

    }

    public class NotEnoughMoneyException : Exception
    {

    }

    class Account
    {
        private decimal _balance;

        public Account():this(0)
        {
        }

        public Account(decimal balance)
        {
            _balance = balance;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount > this._balance)
            {
                return -1;
            }
            else
            {
                this._balance = this._balance - amount;
                return this._balance;
            }
        }
    }
}
