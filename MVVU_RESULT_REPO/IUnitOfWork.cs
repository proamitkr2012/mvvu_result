using System;

namespace MVVU_RESULT_REPO
{
    public interface IUnitOfWork : IDisposable
    {
        AdminMasterRepository IAdminMaster { get; }
        int SaveChanges();
    }
}