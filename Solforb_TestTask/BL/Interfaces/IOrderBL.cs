using Solforb_TestTask.BL.Models;

namespace Solforb_TestTask.BL.Interfaces
{
    public interface IOrderBL
    {
        IEnumerable<OrderModelBL> GetOrders();
    }
}
