using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF
{
    public interface IPizza
    {
        string GetPizza(string pizzaName);
    }
    /// <summary>
    /// 简单工厂,严格来说不算是一种设计模式,是一种代码风格
    /// </summary>
    public class SimpleFactory : IPizza
    {
        public string GetPizza(string Name)
        {
            switch (Name)
            {
                case "apple":
                    return "ApplePiePizza";
                case "beef":
                    return "BeffPizza";
                default:
                    return "Pizza";
            }
        }
    }
}
