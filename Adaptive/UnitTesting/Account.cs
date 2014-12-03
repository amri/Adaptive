namespace UnitTesting
{
    public class Account
    {
        public void AddTransaction(decimal amountDecimal)
        {
            this.Balance += amountDecimal;
        }

        public decimal Balance { get; internal set; }
    }
}