// This file demonstrates the concept: Protecting shared resources from concurrent access
using System;
using System.Threading;

namespace Topics.Multithreading
{
    public class ProtectingSharedResources
    {
        private int counter = 0;
        private object lockObj = new object();

        public void Demo()
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine($"Counter: {counter}");
        }

        void Increment()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (lockObj)
                {
                    counter++;
                }
            }
        }
    }
}
