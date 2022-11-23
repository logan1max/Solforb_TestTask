using Dapper;
using Solforb_TestTask.DAL.Interfaces;
using Solforb_TestTask.DAL.Models;

namespace Solforb_TestTask.DAL.Implementations
{
    public class OrderDAL : IOrderDAL
    {
        public IEnumerable<OrderModelDAL> FindAll()
        {
            using (var connection = DBConnection.CreateConnection())
            {
                return connection.Query<OrderModelDAL>("select * from [Order]");
            }
        }
    }
}
