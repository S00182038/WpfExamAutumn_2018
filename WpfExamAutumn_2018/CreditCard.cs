namespace WpfExamAutumn_2018
{
    public class CreditCard : Account
    {

        public decimal InterestRate { get; set; }
        public int DueDate { get; set; }

        public CreditCard(string accountNumber, decimal balance, decimal interstTare, int dueDate) : base(accountNumber, balance)
        {
            InterestRate = interstTare;
            DueDate = dueDate;
        }
        public CreditCard(string accountNumber) : this(accountNumber, 0, 0, 1)
        {
        }
        public CreditCard() : this("unknown")
        {
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("{0:P} Due Day: {1}", InterestRate, DueDate);
        }
    }
}
