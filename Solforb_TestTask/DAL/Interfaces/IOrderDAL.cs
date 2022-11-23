using Solforb_TestTask.DAL.Models;

namespace Solforb_TestTask.DAL.Interfaces
{
    public interface IOrderDAL
    {
        IEnumerable<OrderModelDAL> FindAll();
    }
}
