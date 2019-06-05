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
        private static void PrintMe()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }

        private static void PrintHelloWorld()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Hello world!");
                Thread.Sleep(250);
            }
        }

        static void Main(string[] args)
        {
            ThreadExecutor executor = new ThreadExecutor();
            for (int i = 0; i < 20; i++)
            {
                executor.Add(new Thread(PrintMe));
                //executor.Execute();
                executor.Add(new Thread(PrintHelloWorld));
                executor.Add(new Thread(() => Console.WriteLine("Hello from lambda!!") ) );
                //executor.Execute();
            }

            Console.WriteLine("Main has finished...............................");
            //executor.ShutDown();

            Thread.Sleep(10 * 1000);
        }
    }
}
