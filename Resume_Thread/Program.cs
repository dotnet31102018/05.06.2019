using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0506
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(
                () =>
                {
                    while (true)
                    {
                        Thread.CurrentThread.Suspend();
                        Console.WriteLine("1 2 3 4 5 6 7 8 9 0");
                    }
                }
                );
            t.Start();

            Thread.Sleep(1000);
            t.Resume();

            Thread.Sleep(1000);
            t.Resume();

            Thread.Sleep(10 * 1000);
        }
    }
}
