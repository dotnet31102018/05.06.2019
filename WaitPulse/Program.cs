using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonDP
{
    class Program
    {
        static object key = new object();
        static void Main(string[] args)
        {
            new Thread(() => { CustomerService(); }).Start();
            new Thread(() => { CustomerService(); }).Start(); 
            new Thread(() => { CustomerService(); }).Start(); 

            Thread.Sleep(100);
            new Thread(() => { Technician(); }).Start();
            Thread.Sleep(100);
            new Thread(() => { Technician(); }).Start();
            Thread.Sleep(100);
            new Thread(() => { Technician(); }).Start();
            Thread.Sleep(100);
            new Thread(() => { Technician(); }).Start();

            Console.ReadLine();
        }
        static int fixedPhones = 0;
        static void CustomerService()
        {
            Monitor.Enter(key);

            Monitor.Wait(key);
            Console.WriteLine("Calling customer....");


            Monitor.Exit(key);
        }
        static void Technician()
        {
            Monitor.Enter(key);

            Console.WriteLine("Fixing phone");
            fixedPhones++;
            Monitor.Pulse(key);

            Monitor.Exit(key);
        }
    }
}
