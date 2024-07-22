using Microsoft.Data.SqlClient;
using System.Data;

namespace ProWebAPIAroject.Context
{
    public class LibraryContext
    {
        private readonly IConfiguration _configuration;
        private readonly String? _connectionString;

        public LibraryContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }
        public IDbConnection dbConnection() => new SqlConnection(_connectionString);

    }
}
