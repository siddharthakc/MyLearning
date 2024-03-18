using Oracle.ManagedDataAccess.Client;

namespace MyLearning.Models
{
    public static class DatabaseContext
    {
        public const string ConnectionString = "User Id=sid;Password=sid;Data Source=localhost:1521/orcl;";

        public static OracleConnection GetOpenConnection()
        {
            OracleConnection connection = new OracleConnection(ConnectionString);
            connection.Open();
            return connection;
        }

    }
}