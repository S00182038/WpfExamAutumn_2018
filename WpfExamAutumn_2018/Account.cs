namespace WpfExamAutumn_2018
{
    public class Account
    {
        public Account(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public Account(string accountNumber) : this(accountNumber, 0)
        {

        }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

    }
}
