namespace UnitTesting
{
    public class FakeAccountRepository : IAccountRepository
    {
        private Account account;

        public FakeAccountRepository(Account account)
        {
            this.account = account;
        }

        public Account GetByName(string accountName)
        {
            return account;
        }
    }
}