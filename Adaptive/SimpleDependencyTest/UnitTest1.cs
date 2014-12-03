using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SimpleDependencyTest
{
    [TestClass]
    public class AccountManagerTestSuite
    {
        [TestMethod]
        public void AccountManagerTest()
        {
            var accountController = new AccountController();
            var userRepository = new Mock<UserRepository>(); //new UserRepository();
            userRepository.Setup(t => t.GetUserByUserId("amri")).Returns(new User());

            string userid = "amri";
            User user = userRepository.Object.GetUserByUserId(userid);
            
            string newPassword = "newpasswrd";
            accountController.ChangePassword(userid, newPassword);
            Assert.AreEqual(newPassword,user.Password);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UserIsEmpty()
        {
            var accountController = new AccountController();
            User user = null;
            accountController.ChangePassword(null, null);
            
        }
    }

    public class User
    {
        public string Password { get; set; }
    }

    public class AccountController
    {
        

        public void ChangePassword(String userid, string newPassword)
        {
            var userRepository = new UserRepository();
            
            User user = userRepository.GetUserByUserId(userid);

            if(null == user)
                throw new ArgumentNullException("user is null");

            user.Password = newPassword;
        }
    }

    public class UserRepository
    {
        public User GetUserByUserId(string userid)
        {
            throw new NotImplementedException();
        }
    }
}
