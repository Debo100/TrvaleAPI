using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace TravelAPI.Data
{
    public class BaseRepository
    {
        public readonly IConfiguration _configuration;
        public readonly string? _connectionstring;
        public BaseRepository( IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionstring = _configuration.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionstring);
    }
}
