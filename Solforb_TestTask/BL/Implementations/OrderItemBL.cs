using AutoMapper;
using Solforb_TestTask.BL.Interfaces;
using Solforb_TestTask.BL.Models;
using Solforb_TestTask.DAL.Implementations;
using Solforb_TestTask.DAL.Interfaces;
using Solforb_TestTask.DAL.Models;

namespace Solforb_TestTask.BL.Implementations
{
    public class OrderItemBL : IOrderItemBL
    {
        private readonly IOrderItemDAL orderItemDAL;

        public OrderItemBL(IOrderItemDAL orderItemDAL)
        {
            this.orderItemDAL = orderItemDAL;
        }

        public IEnumerable<OrderItemModelBL> GetOrderItems()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<OrderItemModelDAL, OrderItemModelBL>()
            );

            var mapper = new Mapper(config);

            IEnumerable <OrderItemModelDAL> orderItemsDAL = orderItemDAL.FindAll();

            IEnumerable<OrderItemModelBL> orderItemsBL = mapper.Map<IEnumerable<OrderItemModelBL>>(orderItemsDAL);

            return orderItemsBL;
        }
    }
}
