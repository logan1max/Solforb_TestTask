using AutoMapper;
using Solforb_TestTask.BL.Interfaces;
using Solforb_TestTask.BL.Models;
using Solforb_TestTask.DAL.Implementations;
using Solforb_TestTask.DAL.Interfaces;
using Solforb_TestTask.DAL.Models;

namespace Solforb_TestTask.BL.Implementations
{
    public class OrderBL : IOrderBL
    {
        private readonly IOrderDAL orderDAL;

        public OrderBL(IOrderDAL orderDAL)
        {
            this.orderDAL = orderDAL;
        }

        public IEnumerable<OrderModelBL> GetOrders()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<OrderModelDAL, OrderModelBL>()
            );

            var mapper = new Mapper(config);

            IEnumerable<OrderModelDAL> ordersDAL = orderDAL.FindAll();

            IEnumerable<OrderModelBL> ordersBL = mapper.Map<IEnumerable<OrderModelBL>>(ordersDAL);

            return ordersBL;
        }
    }
}
