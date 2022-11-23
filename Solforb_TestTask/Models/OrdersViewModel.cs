using Microsoft.AspNetCore.Mvc.Rendering;
using Solforb_TestTask.BL.Models;

namespace Solforb_TestTask.Models
{
    public class OrdersViewModel
    {
        public IEnumerable<OrderModelBL> Orders { get; set; }

        //Dates
        public SelectList StartDate { get; set; }
        public SelectList EndDate  { get; set; }
        //Order
        public SelectList NumberOrder { get; set; }
        public SelectList DateOrder { get; set; }
        public SelectList ProviderIdOrder { get; set; }
        //OrderItem
        public SelectList NameOrderItem { get; set; } 
        public SelectList UnitOrderItem { get; set; }
        //Provider
        public SelectList NameProvider { get; set; }
    }
}