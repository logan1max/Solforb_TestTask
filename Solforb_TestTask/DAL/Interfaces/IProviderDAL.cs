using Solforb_TestTask.DAL.Models;

namespace Solforb_TestTask.DAL.Interfaces
{
    public interface IProviderDAL
    {
        IEnumerable<ProviderModelDAL> FindAll();
    }
}
