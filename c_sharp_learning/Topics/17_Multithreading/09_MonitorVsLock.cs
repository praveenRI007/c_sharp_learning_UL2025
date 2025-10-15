// This file demonstrates the concept: Difference between Monitor and lock
using System;
using System.Threading;

namespace Topics.Multithreading
{
    public class MonitorVsLock
    {
        private int counter = 0;
        private object lockObj = new object();

        public void Demo()
        {
            Thread t1 = new Thread(IncrementWithLock);
            Thread t2 = new Thread(IncrementWithMonitor);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine($"Counter: {counter}");
        }

        void IncrementWithLock()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (lockObj)
                {
                    counter++;
                }
            }
        }

        void IncrementWithMonitor()
        {
            for (int i = 0; i < 1000; i++)
            {
                bool lockTaken = false;
                try
                {
                    Monitor.Enter(lockObj, ref lockTaken);
                    counter++;
                }
                finally
                {
                    if (lockTaken) Monitor.Exit(lockObj);
                }
            }
        }
    }
}
