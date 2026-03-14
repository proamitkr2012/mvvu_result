using MVVU_RESULT_MODEL.DTO;
using MVVU_RESULT_DATA.Entities;
using System;
using System.Collections.Generic;
using MVVU_RESULT_MODEL;
using System.Threading.Tasks;
using MVVU_RESULT_MODEL.DTO.Result;

namespace MVVU_RESULT_REPO
{
    public interface IAdminMasterRepository : IRepository<AdminMaster>
    {
        //admin-login
        Task<AdminMasterDTO> AuthenticateAdmin(string userName, string password);
        bool IsAdminEmailExists(string email);
        
        Task<FormResponse> VisitCountSet(StudentMasterDTOCount model);

    }
}
