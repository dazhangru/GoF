using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF
{
    public abstract class AbstractFactory
    {
        public abstract void GetPizza();
        public abstract void GetPrice();
    }
    public class Apple_PizzaFactory : AbstractFactory
    {
        public override void GetPizza()
        {
            Console.WriteLine("ApplePizza");
        }
        public override void GetPrice()
        {
            Console.WriteLine("10元");
        }
    }
    public class Buff_PizzaFactory : AbstractFactory
    {
        public override void GetPizza()
        {
            Console.WriteLine("BuffPizza");
        }
        public override void GetPrice()
        {
            Console.WriteLine("20元");
        }
    }
}
