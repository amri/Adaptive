using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTesting
{
    [TestClass]
    public class AccountServiceTest
    {
        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            var account = new Account();

            var mockRepository = new Mock<IAccountRepository>();

            mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(account);

            var sut = new AccountService(mockRepository.Object);

            sut.AddTransactionToAccount("Trading Account", 200m);

            Assert.AreEqual(200m,account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CannotCreateAccountServiceWithNullAccountRepository()
        {
            var accountService = new AccountService(null);
        }
    }
}
