using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0506
{
    class ThreadExecutor
    {
        Queue<Thread> _threadsQueue = new Queue<Thread>();

        public void Add(Thread thread)
        {
            lock (this)
            {
                Console.WriteLine($"new thread entered the queue");
                if (thread != null)
                {
                    _threadsQueue.Enqueue(thread);
                }
            }
        }

        public void Execute()
        {
            lock (this)
            {
                while (_threadsQueue.Count > 0)
                {
                    // with Peek
                    //Thread _current = _threadsQueue.Peek();
                    //_current.Start();
                    //_current.Join();
                    //_threadsQueue.Dequeue();

                    Thread current = _threadsQueue.Dequeue();

                    current.Start();

                    //current.Join();
                }
            }
        }
    }
}
