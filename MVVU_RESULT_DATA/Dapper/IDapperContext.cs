
using MVVU_RESULT_DATA.Dapper.Interfaces;

namespace MVVU_RESULT_DATA.Dapper
{
    public interface IDapperContext
    {
        IQueryHelper QueryHelper { get; }
        IProcedureHelper ProcedureHelper { get; }
    }
}
