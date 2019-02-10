namespace DemoWebApplication.Card
{
    public class MasterCard : CreditCard
    {
        private static double INTEREST_RATE = 0.05;
        private double balance;
        private double interest;

        public MasterCard(double balance)
        {
            setBalance(balance);
            setInterest();
        }

        public double getInterestRate()
        {
            return INTEREST_RATE;
        }
        public double getInterest()
        {
            return interest;
        }

        public void setInterest()
        {
            interest = balance * INTEREST_RATE;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }
    }
}