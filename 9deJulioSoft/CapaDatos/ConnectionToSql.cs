using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionstring;
        public ConnectionToSql()
        {
            connectionstring = "Server=localhost\\SQLEXPRESS;DataBase= NuevedeJulio;Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }

    }
}
