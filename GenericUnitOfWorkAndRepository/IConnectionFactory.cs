using System.Data;

namespace GenericUnitOfWorkAndRepository
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
