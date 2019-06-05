using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.GetInstance().WriteLog("hello");
            Singleton.GetInstance().WriteLog("world");
        }
    }
}
