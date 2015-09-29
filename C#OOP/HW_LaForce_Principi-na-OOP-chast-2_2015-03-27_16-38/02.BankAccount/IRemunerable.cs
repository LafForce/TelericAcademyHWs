namespace BankAccounts
{
    public interface IRemunerable
    {
        decimal InterestRate { get; set; }
        decimal CalculateInterestAmount();
    }
}
