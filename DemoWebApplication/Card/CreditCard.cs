namespace DemoWebApplication.Card
{
    public interface CreditCard
    {
        double getInterestRate();

        double getInterest();

        void setInterest();

        double getBalance();

        void setBalance(double balance);

    }
}
