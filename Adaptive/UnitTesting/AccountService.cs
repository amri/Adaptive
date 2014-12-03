using System;

namespace UnitTesting
{
    public class AccountService
    {
        private IAccountRepository repository;

        public AccountService(IAccountRepository repository)
        {
            this.repository = repository;
        }

        public void AddTransactionToAccount(string tradingAccount, decimal amount)
        {
            Account retrievedAccount = repository.GetByName(tradingAccount);
            retrievedAccount.AddTransaction(amount);
        }
    }
}