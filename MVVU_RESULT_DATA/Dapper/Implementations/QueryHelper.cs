
using Dapper;
using MVVU_RESULT_DATA.Dapper.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVVU_RESULT_DATA.Dapper.Implementations
{
    public class QueryHelper : IQueryHelper
    {
        private readonly ISqlConnectionHelper _sqlConnectionProvider;

        public QueryHelper(ISqlConnectionHelper sqlConnectionProvider)
        {
            _sqlConnectionProvider = sqlConnectionProvider;
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object parameters = null)
        {
            using (var connection = _sqlConnectionProvider.GetDbConnection())
            {
                return await connection.QueryAsync<T>(sql, parameters);
            }
        }
        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object parameters = null)
        {
            using (var connection = _sqlConnectionProvider.GetDbConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<T>(sql, parameters);
            }
        }
    }
}
