using System.Data.SqlClient;

namespace Insurance.util
{
    public class DBConnUtil
    {
        private static SqlConnection conn;

        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                string connectionString = DBPropertyUtil.GetPropertyString("db.properties");
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            return conn;
        }
    }
}
