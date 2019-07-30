using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDemo
{
    interface ILogger
    {
        void Log(int level, string msg);
        //void Log(Exception ex) => Log(1, ex.Message);
    }
}
