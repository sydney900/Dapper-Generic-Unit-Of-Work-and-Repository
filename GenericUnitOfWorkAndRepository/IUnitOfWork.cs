using System;
using System.Threading.Tasks;

namespace GenericUnitOfWorkAndRepository
{
    public interface IUnitOfWork: IDisposable 
    {
        IRepository<T> Repository<T>() where T : BaseEntity;
        void BeginTransaction();
        bool Commit();
        void Rollback();
        void Dispose(bool disposing);
    }
}
