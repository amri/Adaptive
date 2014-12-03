using System;

namespace SimpleDependency
{
    public interface ISecurityService
    {
        void ChangeUserPassword(Guid user, string newPassword);
    }

    class SecurityService : ISecurityService
    {
        public void ChangeUserPassword(Guid user, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}