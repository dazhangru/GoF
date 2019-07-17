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
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDto>());
            var mapper = config.CreateMapper();
            Order order = new Order { OrderId = 1000, Price = "100.00", ProductId=1 };
            OrderDto dto = mapper.Map<OrderDto>(order);
            Console.WriteLine("");
        }
    }
    class Order
    {
        public int OrderId { get; set; }
        public string Price { get; set; }
        public int ProductId { get; set; }
    }
    class OrderDto
    {
        public int OrderId { get; set; }
        public string Price { get; set; }
        public string ProductName { get; set; }
    }
}
