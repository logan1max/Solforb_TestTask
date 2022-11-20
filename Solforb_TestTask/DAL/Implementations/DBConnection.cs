using System.Data.SqlClient;

namespace Solforb_TestTask.DAL.Implementations
{
    public class DBConnection
    {
        public static SqlConnection CreateConnection()
        {
            try
            {
                return new SqlConnection("Server=.\\SQLEXPRESS;Initial Catalog=SolForB;Integrated Security=True;");
            }
            catch
            {
                return null;
            }
        }
    }
}
