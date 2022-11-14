using Microsoft.Data.SqlClient;

namespace Solforb_TestTask.DAL.Implementations
{
    public class DBConnection
    {
        public static SqlConnection CreateConnection()
        {
            try
            {
                return new SqlConnection("");
            }
            catch
            {
                return null;
            }
        }
    }
}
