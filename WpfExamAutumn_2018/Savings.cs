namespace WpfExamAutumn_2018
{
    public class Savings : Account
    {
        public Savings(string accountNumber, decimal balance, decimal savingRate) : base(accountNumber, balance)
        {
            SavingsRate = savingRate;
        }
        public Savings(string accountNumber) : this(accountNumber, 0, 0)
        {

        }
        public Savings() : this("Unknow")
        {

        }
        public decimal SavingsRate { get; set; }
        public override string ToString()
        {
            return base.ToString() + string.Format("{0:P", SavingsRate);
        }
    }
}
