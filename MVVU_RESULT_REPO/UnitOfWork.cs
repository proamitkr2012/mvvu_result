using Microsoft.Extensions.Configuration;
using MVVU_RESULT_DATA;
using MVVU_RESULT_DATA.Dapper;
using MVVU_RESULT_REPO.Utilities;
using System;

namespace MVVU_RESULT_REPO
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext db;
         private IMailClient _mailClient; 
        IDapperContext _dapperContext;
        protected IConfiguration config;
        public UnitOfWork(DataContext _db, IDapperContext dapperContext, IMailClient mailClient, IConfiguration _config)
        {
            db = _db;
            _dapperContext = dapperContext;
            config = _config;
        }

        private AdminMasterRepository _IAdminMaster;
        public AdminMasterRepository IAdminMaster
        {
            get
            {
                if (this._IAdminMaster == null)
                {
                    this._IAdminMaster = new AdminMasterRepository(db, _dapperContext, config);
                }
                return this._IAdminMaster;
            }
        }


        public int SaveChanges()
        {
            return db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
