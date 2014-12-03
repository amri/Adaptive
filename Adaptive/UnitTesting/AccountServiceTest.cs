using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class AccountServiceTest
    {
        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            var account = new Account();
            IAccountRepository repository = new FakeAccountRepository(account);
            var sut = new AccountService(repository);

            sut.AddTransactionToAccount("Trading Account", 200m);

            Assert.AreEqual(200m,account.Balance);
        }
    }
}
