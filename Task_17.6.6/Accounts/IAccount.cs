namespace Task_17._6._6.Accounts
{
    public interface IAccount
    {
        double Balance { get; set; }

        double Interest { get; set; }

        void CalculateInterest();
    }
}
