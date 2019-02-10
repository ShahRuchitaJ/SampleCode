using Xunit;
using DemoWebApplication.Card;
using DemoWebApplication.Person;
using DemoWebApplication.wallet;

namespace DemoWebApplicationTests
{
    public class UnitTest3
    {
        public static CreditCard[] cardsP1 = { new MasterCard(100), new Visa(100) };
        public static CreditCard[] cardsP2 = { new Visa(100), new MasterCard(100) };
        public static Wallet[] p1wallet = { new Wallet(cardsP1) };
        public static Wallet[] p2wallet = { new Wallet(cardsP2) };
        public static Person person1 = new Person(p1wallet);
        public static Person person2 = new Person(p2wallet);


        [Fact]
        public void person1InterestShouldReturnFifteen()
        {
            Assert.Equal(15.0, person1.getInterest(), 0);
        }

        [Fact]
        public void person2InterestShouldReturnFifteen()
        {
            Assert.Equal(15.0, person2.getInterest(), 0);
        }

        [Fact]
        public void person1WalletInterestShouldReturnFifteen()
        {
            Assert.Equal(15.0, p1wallet[0].getInterest(), 0);
        }

        [Fact]
        public void person2WalletInterestShouldReturnFifteen()
        {
            Assert.Equal(15.0, p2wallet[0].getInterest(), 0);
        }
    }
}
