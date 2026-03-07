
using System.Data;

namespace MVVU_RESULT_DATA.Dapper.Interfaces
{
    public interface ISqlConnectionHelper
    {
        IDbConnection GetDbConnection();
    }
}
