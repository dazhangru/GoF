using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDto>());
            //var mapper = config.CreateMapper();
            //Order order = new Order { OrderId = 1000, Price = "100.00", ProductId = 1 };
            //OrderDto dto = mapper.Map<OrderDto>(order);
            Order order = new Order();
            order.dto = new OrderDto();
            order.dto.Price = "100";
            order.dto.OrderId = 1;
            order.dto.ProductName = "苹果";
            order.Show();
            Console.Read();
        }
    }
    class Order
    {
        private int productId;

        public int OrderId { get; set; }
        public string Price { get; set; }

        public int GetProductId()
        {
            return productId;
        }

        public void SetProductId(int value)
        {
            productId = value;
        }

        public OrderDto dto { get; set; }
        public void Show()
        {
            Console.WriteLine(dto.OrderId + "..." + dto.Price + "..." + dto.ProductName);
        }
    }
    class OrderDto
    {
        public OrderDto()
        {

        }
        public int OrderId { get; set; }
        public string Price { get; set; }
        public string ProductName { get; set; }
    }
}
