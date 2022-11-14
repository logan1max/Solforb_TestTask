using Dapper;
using Solforb_TestTask.DAL.Interfaces;
using Solforb_TestTask.DAL.Models;

namespace Solforb_TestTask.DAL.Implementations
{
    public class ProviderDAL : IProviderDAL
    {
        public IEnumerable<ProviderModelDAL> FindAll()
        {
            using (var connection = DBConnection.CreateConnection())
            {
                return connection.Query<ProviderModelDAL>("select * from [Provider]");
            }
        }
    }
}
