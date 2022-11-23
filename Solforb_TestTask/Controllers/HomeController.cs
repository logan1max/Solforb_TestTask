using Microsoft.AspNetCore.Mvc;
using Solforb_TestTask.BL.Interfaces;
using Solforb_TestTask.BL.Models;
using Solforb_TestTask.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Solforb_TestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProviderBL providerBL;
        private readonly IOrderBL orderBL;
        private readonly IOrderItemBL orderItemBL;

        public HomeController(
            ILogger<HomeController> logger,
            IProviderBL providerBL,
            IOrderBL orderBL,
            IOrderItemBL orderItemBL)
        {
            _logger = logger;
            this.providerBL = providerBL;
            this.orderBL = orderBL;
            this.orderItemBL = orderItemBL;
        }

        [HttpGet]
        public ActionResult Index()
        {
            IQueryable<OrderModelBL> orders = orderBL.GetOrders().AsQueryable();

            List<string> temp = new List<string>() { "1", "2", "3" };
            List<string> temp1 = new List<string>();

            OrdersViewModel ordersView = new OrdersViewModel()
            {
                Orders = orders,
                DateOrder = new SelectList(temp),
                NameOrderItem = new SelectList(temp),
                NameProvider = new SelectList(temp),
                NumberOrder = new SelectList(temp),
                ProviderIdOrder = new SelectList(temp),
                UnitOrderItem = new SelectList(temp)
            };

            return View(ordersView);
        }

        [HttpPost]
        public ActionResult Index(OrdersViewModel ordersViewModel)
        {
            try
            {
                if(ModelState.IsValid)
                {

                }

                IQueryable<OrderModelBL> orders = orderBL.GetOrders().AsQueryable();
                //IQueryable<OrderItemModelBL> orderItems = orderItemBL.GetOrderItems().AsQueryable();
                //IQueryable<ProviderModelBL> providers = providerBL.GetProviders().AsQueryable();

                List<string> temp = new List<string>() { "1", "2", "3" };
                List<string> temp1 = new List<string>();

                OrdersViewModel ordersView = new OrdersViewModel()
                {
                    Orders = orders,
                    DateOrder = new SelectList(temp),
                    NameOrderItem = new SelectList(temp),
                    NameProvider = new SelectList(temp),
                    NumberOrder = new SelectList(temp),
                    ProviderIdOrder = new SelectList(temp),
                    UnitOrderItem = new SelectList(temp)
                };

                return View(ordersView);
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}