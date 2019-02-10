using Xunit;
using DemoWebApplication.Card;
using DemoWebApplication.Person;
using DemoWebApplication.wallet;

namespace DemoWebApplicationTests
{
    public class UnitTest1
    {
        public static CreditCard[] cards = { new Visa(100), new MasterCard(100), new Discover(100) };
        public static Wallet[] wallet = { new Wallet(cards) };
        public static Person person = new Person(wallet);

        [Fact()]
        public void personInterestShouldReturnSixteen()
        {
            Assert.Equal(16.0, person.getInterest(), 1);
        }

        [Fact()]
        public void visaInterestShouldReturnTen()
        {
            Assert.Equal(10.0, cards[0].getInterest(), 0);
        }

        [Fact()]
        public void mastercardInterestShouldReturnFive()
        {
            Assert.Equal(5.0, cards[1].getInterest(), 0);
        }

        [Fact()]
        public void discoverInterestShouldReturnOne()
        {
            Assert.Equal(1.0, cards[2].getInterest(), 0);
        }
    }
}