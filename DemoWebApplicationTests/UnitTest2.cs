using Xunit;
using DemoWebApplication.Card;
using DemoWebApplication.wallet;
using DemoWebApplication.Person;

namespace DemoWebApplicationTests
{
    public class UnitTest2
    {
        public static CreditCard[] cardsInWallet1 = { new Visa(100), new Discover(100) };
        public static CreditCard[] cardsInWallet2 = { new MasterCard(100) };
        public static Wallet[] wallets = { new Wallet(cardsInWallet1), new Wallet(cardsInWallet2) };
        public static Person person = new Person(wallets);


        [Fact]
        public void personInterestShouldReturnSixteen()
        {
            Assert.Equal(16.0, person.getInterest(), 0);
        }

        [Fact]
        public void wallet1ShouldReturnEleven()
        {
            Assert.Equal(11.0, wallets[0].getInterest(), 0);
        }

        [Fact]
        public void wallet2ShouldReturnFive()
        {
            Assert.Equal(5.0, wallets[1].getInterest(), 0);
        }

    }
}
