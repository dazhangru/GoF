using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂
            //SimpleFactory factory = new SimpleFactory();
            //Console.WriteLine(factory.GetPizza("apple"));
            //Console.Read(); 
            #endregion
            #region 工厂方法
            //ApplePizzaFactory factory = new ApplePizzaFactory();
            //factory.GetPizza();
            //BuffPizzaFactory buffPizzaFactory = new BuffPizzaFactory();
            //buffPizzaFactory.GetPizza();
            //Console.ReadKey();
            #endregion
            #region 抽象工厂
            Apple_PizzaFactory factory = new Apple_PizzaFactory();
            Buff_PizzaFactory buff_PizzaFactory = new Buff_PizzaFactory();
            factory.GetPizza();
            factory.GetPrice();
            buff_PizzaFactory.GetPizza();
            buff_PizzaFactory.GetPrice();
            Console.ReadKey(); 
            #endregion
        }
    }
}
