using System;
using Kodetime09._05;
using Xunit;

namespace BrusAutomatTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestCoinInput()
        {
            var test1 = new Coin(0);
            test1.CoinInput(15);//godtar kun 1,5,10,20
            var expected = 0;
            var actual = test1.CoinBalance;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestIfBalanceIncreases()
        {
            var test2 = new Coin(0);
            test2.CoinInput(10);
            var expected = 10;
            var actual = test2.CoinBalance;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void BalanceAfterReturn()
        {
            var test3 = new Coin(40);
            test3.ReturnBalance();
            var expected = 0;
            var actual = test3.CoinBalance;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCtrValues()
        {
            var brusTest1 = new Brus("Fanta", 20, 3, 0);
            Assert.Equal("Fanta", brusTest1.Name);
            Assert.Equal(20, brusTest1.Price);
            Assert.Equal(3, brusTest1.Inventory);
            Assert.Equal(0, brusTest1.Id);
        }

        [Fact]
        public void NoSodaInList()
        {
            var automatTest = new BrusAutomat();
            var expected = 0;
            var actual = automatTest.BrusListe.Count;
            Assert.Equal(expected, actual);
        }

        //addSodaToList

    }
}
