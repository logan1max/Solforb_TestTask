using Microsoft.AspNetCore.Mvc.Rendering;
using Solforb_TestTask.BL.Models;

namespace Solforb_TestTask.Models
{
#if true

#endif
    public class OrdersViewModel
    {
        public IEnumerable<OrderModelBL> Orders { get; set; }
        public SelectList NumberOrder { get; set; }
        public SelectList DateOrder { get; set; }
        public SelectList ProviderIdOrder { get; set; }

        public 
    }
}
