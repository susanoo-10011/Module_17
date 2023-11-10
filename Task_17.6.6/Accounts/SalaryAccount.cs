

namespace Task_17._6._6.Accounts
{
    public class SalaryAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
