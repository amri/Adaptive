namespace UnitTesting
{
    public interface IAccountRepository
    {
         Account GetByName(string accountName);
    }
}