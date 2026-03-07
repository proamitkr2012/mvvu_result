using MVVU_RESULT_MODEL;
using MVVU_RESULT_DATA.Entities;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace MVVU_RESULT_REPO.Utilities
{
    public interface IMailClient
    {
        

        bool SendMail(string to, string subject, string body);
        bool SendMulpMail(string to, string subject, string body);
        

    }
}