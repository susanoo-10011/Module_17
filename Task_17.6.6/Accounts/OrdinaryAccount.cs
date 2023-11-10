

namespace Task_17._6._6.Accounts
{
    public class OrdinaryAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;
            else
                Interest -= Balance * 0.4;
        }
    }
}
