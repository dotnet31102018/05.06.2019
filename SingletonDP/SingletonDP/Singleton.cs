using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDP
{
    class Singleton
    {

        private static Singleton _instance;
        private static object key = new object();
        private Singleton()
        {

        }

        public void WriteLog(string log)
        {

        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (key)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}
