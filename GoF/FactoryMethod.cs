using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF
{
    public abstract class FactoryMethod
    {
        public abstract void GetPizza();
    }
    public class ApplePizzaFactory : FactoryMethod
    {
        public override void GetPizza()
        {
            Console.WriteLine("ApplePizza");
        }
    }
    public class BuffPizzaFactory : FactoryMethod
    {
        public override void GetPizza()
        {
            Console.WriteLine("BuffPizza");
        }
    }
}
