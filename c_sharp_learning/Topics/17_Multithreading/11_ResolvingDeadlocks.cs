// This file demonstrates the concept: Resolving deadlocks in a multithreaded program
using System;
using System.Threading;

namespace Topics.Multithreading
{
    public class ResolvingDeadlocks
    {
        private object lockA = new object();
        private object lockB = new object();

        public void Demo()
        {
            Thread t1 = new Thread(Thread1);
            Thread t2 = new Thread(Thread2);
            t1.Start();
            t2.Start();
        }

        void Thread1()
        {
            lock (lockA)
            {
                Thread.Sleep(100);
                lock (lockB)
                {
                    Console.WriteLine("Thread1 acquired both locks safely");
                }
            }
        }

        void Thread2()
        {
            lock (lockA) // Always lock in the same order to avoid deadlock
            {
                Thread.Sleep(100);
                lock (lockB)
                {
                    Console.WriteLine("Thread2 acquired both locks safely");
                }
            }
        }
    }
}
