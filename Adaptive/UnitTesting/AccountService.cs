using System;

namespace UnitTesting
{
    public class AccountService
    {
        private IAccountRepository repository;

        public AccountService(IAccountRepository repository)
        {
            if(repository == null)
                throw new ArgumentNullException("repository","A valid account repository must be supplied");
            this.repository = repository;
        }

        public void AddTransactionToAccount(string tradingAccount, decimal amount)
        {
            Account retrievedAccount = repository.GetByName(tradingAccount);
            retrievedAccount.AddTransaction(amount);
        }
    }
}